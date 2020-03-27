using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPF_Project.Extensions;
using WPF_Project.Messages;
using WPF_Project.Model;
using WPF_Project.Services;
using WPF_Project.Utillity;

namespace WPF_Project.ViewModel
{
    public class TaskDetailsViewModel : INotifyPropertyChanged
    {
        private IFourWheelDataService _DataService;
        private IDialogService _DialogService;

        public TaskDetailsViewModel(IFourWheelDataService dataService, IDialogService dialogService)
        {
            _DataService = dataService;
            _DialogService = dialogService;

            // Receive UpdateTaskDetailsMessage send from TaskAdminWindow or spareparts catalog
            Messenger.Default.Register<UpdateTaskDetailsMessage>(this, OnTaskDetailsReceived);

            LoadCommands();
        }


        private void LoadData()
        {
            Customers = _DataService.GetAllCustomers().ToObservableCollection();
        }

        private void OnTaskDetailsReceived(UpdateTaskDetailsMessage taskDetails)
        {
            LoadData();
            SelectedTask = taskDetails.Task;
            if (taskDetails.Task.Car != null)
            {
                selectedCustomer = taskDetails.Task.Car.Customer;
            }

            _DialogService.CloseSparepartsWindows();
        }

        #region PROPERTIES
        ObservableCollection<Customer> customers;
        public ObservableCollection<Customer> Customers
        {
            get => customers;
            set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        private Task selectedTask;
        public Task SelectedTask
        {
            get => selectedTask;
            set
            {
                selectedTask = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region COMMANDS
        public ICommand SaveTaskCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }
        public ICommand AddSparepartCommand { get; set; }
        public ICommand RemoveSparepartCommand { get; set; }

        private void LoadCommands()
        {
            SaveTaskCommand = new CustomCommand(SaveTask, CanSaveTask);
            DeleteTaskCommand = new CustomCommand(DeleteTask, CanDeleteTask);
            AddSparepartCommand = new CustomCommand(AddSparepart, CanAddSparepart);
            RemoveSparepartCommand = new CustomCommand(RemoveSparepart, CanRemoveSparepart);
        }

        private void SaveTask(object task)
        {
            _DataService.UpdateTask(selectedTask);

            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage("Task Saved!"));
        }

        private void DeleteTask(object task)
        {
            _DataService.DeleteTask(selectedTask);

            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage("Task Deleted!"));
        }

        private void AddSparepart(object obj)
        {
            _DialogService.ShowSparepartsWindow();


            Messenger.Default.Send<Task>(SelectedTask);
        }

        private void RemoveSparepart(object obj)
        {
            Sparepart selectedSparePart = (Sparepart)obj;

            SelectedTask.Spareparts.Remove(selectedSparePart);
        }

        private bool CanSaveTask(object obj)
        {
            if (SelectedTask != null)
            {
                if (SelectedTask.Car != null && !string.IsNullOrEmpty(SelectedTask.Description))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CanDeleteTask(object obj)
        {
            return true;
        }

        private bool CanAddSparepart(object obj)
        {
            return true;
        }

        private bool CanRemoveSparepart(object obj)
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
