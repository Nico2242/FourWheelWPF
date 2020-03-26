using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WPF_Project.Extensions;
using WPF_Project.Messages;
using WPF_Project.Model;
using WPF_Project.Services;
using WPF_Project.Utillity;

namespace WPF_Project.ViewModel
{
    public class TaskAdminViewModel : INotifyPropertyChanged
    {
        private IFourWheelDataService _DataService;
        private IDialogService _DialogService;

        public TaskAdminViewModel(IFourWheelDataService dataService, IDialogService dialogService)
        {
            _DataService = dataService;
            _DialogService = dialogService;
            LoadData();
            LoadCommands();

            // Listen/register the updatelistmessage object which will be send fro task details window whenever a task is updated or delete, then call OnUpdateListMessageReceived
            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }

        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            MessageBox.Show(obj.Message);
            _DialogService.CloseTaskDetailsDialog();
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
        private void LoadCommands()
        {
            EditTaskCommand = new CustomCommand(EditTask, CanEditTask);
            AddTaskCommand = new CustomCommand(AddTask, CanAddTask);
        }


        public ICommand AddTaskCommand { get; set; }
        private void AddTask(object obj)
        {
            Task task = new Task();

            // Send Task object out so TaskDetailsWindow can receive it 
            Messenger.Default.Send<Task>(task);

            _DialogService.ShowTaskDetailsDialog();
        }

        private bool CanAddTask(object obj)
        {
            return true;
        }

        public ICommand EditTaskCommand { get; set; }
        private void EditTask(object obj)
        {
            Task task = (Task)obj;

            // Send Task object out so TaskDetailsWindow can receive it 
            Messenger.Default.Send<Task>(task);

            _DialogService.ShowTaskDetailsDialog();
        }

        private bool CanEditTask(object obj)
        {
            if (obj != null)
            {
                Task task = (Task)obj;
                if (task != null)
                {
                    return true;
                }

                return false;
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
