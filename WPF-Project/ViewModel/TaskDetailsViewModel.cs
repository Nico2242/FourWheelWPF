using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using WPF_Project.Extensions;
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
        }

        private void LoadData()
        {
            Customers = _DataService.GetAllCustomers().ToObservableCollection();
        }

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

        private bool isCarsComboBoxEnabled;
        public bool IsCarsComboBoxEnabled
        {
            get => isCarsComboBoxEnabled;
            set
            {
                isCarsComboBoxEnabled = value;
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

        private void OnTaskReceived(Task task)
        {
            SelectedTask = task;
            selectedCustomer = task.Car.Customer;
        }

        #region PROPERTY CHANGED EVENT
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
