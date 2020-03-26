using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using WPF_Project.Extensions;
using WPF_Project.Model;
using WPF_Project.Services;

namespace WPF_Project.ViewModel
{
    public class TaskAdminWindowViewModel : INotifyPropertyChanged
    {
        private IFourWheelDataService _DataService;

        public TaskAdminWindowViewModel()
        {
            _DataService = new FourWheelDataService();
            LoadData();
        }

        private void LoadData()
        {
            Tasks = _DataService.GetAllTasks().ToObservableCollection();
        }

        ObservableCollection<Task> tasks;
        public ObservableCollection<Task> Tasks 
        {
            get => tasks;
            set
            {
                tasks = value;
                OnPropertyChanged();
            } 
        }

        #region COMMANDS
        public ICommand AddTaskCommand { get; set; }
        private void AddTask()
        {
            
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
