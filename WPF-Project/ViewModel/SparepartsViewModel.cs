using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPF_Project.Extensions;
using WPF_Project.Messages;
using WPF_Project.Model;
using WPF_Project.Services;
using WPF_Project.Utillity;

namespace WPF_Project.ViewModel
{
    public class SparepartsViewModel : INotifyPropertyChanged
    {
        private IFourWheelDataService _DataService;
        private IDialogService _DialogService;

        public SparepartsViewModel(IFourWheelDataService dataService, IDialogService dialogService)
        {
            _DataService = dataService;
            _DialogService = dialogService;
            LoadData();
            LoadCommands();

            Messenger.Default.Register<Task>(this, OnTaskReceived);
        }

        private void OnTaskReceived(Task task)
        {
            TaskToUpdate = task;
        }

        private void LoadData()
        {
            Spareparts = _DataService.GetAllSpareparts().ToObservableCollection();
        }

        #region PROPERTIES
        ObservableCollection<Sparepart> spareparts;
        public ObservableCollection<Sparepart> Spareparts
        {
            get => spareparts;
            set
            {
                spareparts = value;
                OnPropertyChanged();
            }
        }

        Task taskToUpdate;
        public Task TaskToUpdate
        {
            get => taskToUpdate;
            set
            {
                taskToUpdate = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region COMMANDS
        public ICommand AddSparepartCommand { get; set; }

        private void LoadCommands()
        {
            AddSparepartCommand = new CustomCommand(AddSparepart, CanAddSparepart);
        }

        private void AddSparepart(object obj)
        {
            if (taskToUpdate.Spareparts == null)
            {
                taskToUpdate.Spareparts = new ObservableCollection<Sparepart>();
            }

            IList objList = (IList)obj;

            List<Sparepart> spareparts = objList.Cast<Sparepart>().ToList();


            foreach (Sparepart sparepart in spareparts)
            {
                TaskToUpdate.Spareparts.Add(sparepart);
            }


            Messenger.Default.Send<UpdateTaskDetailsMessage>(new UpdateTaskDetailsMessage(TaskToUpdate));

        }

        private bool CanAddSparepart(object obj)
        {
            if (obj != null)
            {
                return true;
            }
            return false;
        }
        #endregion
        
        #region PROPERTY CHANGED EVENT
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
