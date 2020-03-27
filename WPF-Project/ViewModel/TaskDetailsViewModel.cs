using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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

            // Receive Task Object send from TaskAdminWindow
            Messenger.Default.Register<Task>(this, OnTaskReceived);

            LoadData();
            LoadCommands();
        }

        private void LoadData()
        {
            Customers = _DataService.GetAllCustomers().ToObservableCollection();
        }
        private void OnTaskReceived(Task task)
        {
            SelectedTask = task;
            if (task.Car != null)
            {
                selectedCustomer = task.Car.Customer;
            }
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

        private void LoadCommands()
        {
            SaveTaskCommand = new CustomCommand(SaveTask, CanSaveTask);
            DeleteTaskCommand = new CustomCommand(DeleteTask, CanDeleteTask);
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

        private bool CanSaveTask(object obj)
        {
            return true;
        }

        private bool CanDeleteTask(object obj)
        {
            return true;
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
