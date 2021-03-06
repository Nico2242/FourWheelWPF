﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Input;
using WPF_Project.Extensions;
using WPF_Project.Model;
using WPF_Project.Services;
using WPF_Project.Utillity;

namespace WPF_Project.ViewModel
{
    public class CustomerAdminViewModel : INotifyPropertyChanged
    {
        private IFourWheelDataService _DataService;
        private CollectionViewSource customerCollection;

        public CustomerAdminViewModel(IFourWheelDataService dataService, IDialogService dialogService)
        {
            _DataService = dataService;
            LoadData();
            LoadCommands();

            customerCollection = new CollectionViewSource();
            customerCollection.Source = customers;
            customerCollection.Filter += customerCollection_Filter;
        }



        private void LoadData()
        {
            Customers = _DataService.GetAllCustomers().ToObservableCollection();
        }

        private void customerCollection_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            Customer customer = (Customer)e.Item;
            if (customer.Name.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
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

        public ICollectionView CustomerCollectionView
        {
            get
            {
                return this.customerCollection.View;
            }
        }

        string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                this.customerCollection.View.Refresh();
                OnPropertyChanged();
            }
        }
        #endregion

        #region COMMANDS
        public ICommand AddCustomerCommand { get; set; }
        public ICommand AddCarCommand { get; set; }

        private void LoadCommands()
        {
            AddCustomerCommand = new CustomCommand(AddCustomer, CanAddCustomer);
            AddCarCommand = new CustomCommand(AddCar, CanAddCar);
        }

        private void AddCustomer(object obj)
        {

            var values = (object[])obj;

            Customer newCustomer = new Customer
            {
                Id = Customers.Count + 1,
                Name = values[0].ToString(),
                Surname = values[1].ToString(),
                Mail = values[2].ToString(),
                Cars = new ObservableCollection<Car>()
            };

            _DataService.AddCustomer(newCustomer);

            Customers.Add(newCustomer);
        }

        private void AddCar(object obj)
        {
            var values = (object[])obj;

            int highestCarId = 0;

            Customer selectedCustomer = (Customer)values[0];


            // Get Highest car id
            foreach (Customer cust in Customers)
            {
                if (cust.Cars != null)
                {
                    foreach (Car car in cust.Cars)
                    {
                        int carId = car.Id;

                        if (carId > highestCarId)
                        {
                            highestCarId = carId;
                        }
                    }
                }
            }

            Car newCar = new Car
            {
                Id = highestCarId++,
                Brand = (CarBrand)values[1],
                Model = values[2].ToString(),
                Plate = values[3].ToString(),
                Customer = selectedCustomer
            };

            _DataService.AddCar(newCar);
        }

        private bool CanAddCustomer(object obj)
        {
            if (obj != null)
            {
                object[] values = (object[])obj;

                if (values[0].ToString().Length > 0 && values[1].ToString().Length > 0 && values[2].ToString().Length > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool CanAddCar(object obj)
        {
            if (obj != null)
            {
                object[] values = (object[])obj;

                Customer customer = (Customer)values[0];

                if (customer != null && (CarBrand)values[1] != CarBrand.None && values[2].ToString().Length > 0 && values[3].ToString().Length > 0)
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