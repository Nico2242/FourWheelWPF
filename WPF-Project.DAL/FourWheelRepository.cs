using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WPF_Project.Model;

namespace WPF_Project.DAL
{
    public class FourWheelRepository : IFourWheelRepository
    {
        static List<Customer> customers;
        static List<Task> tasks;

        public List<Task> GetTasks()
        {
            if (tasks == null)
                LoadTasks();
            return tasks;
        }

        public List<Customer> GetCustomers()
        {
            if (customers == null)
                LoadCustomers();
            return customers;
        }

        private void LoadTasks()
        {
            tasks = new List<Task>
            {
                new Task
                {
                    Id = 1,
                    Description = "Service",
                    Status = false,
                    Car = customers.FirstOrDefault(c => c.Id == 1).Cars.FirstOrDefault(),
                    Spareparts = new ObservableCollection<Sparepart>
                    {
                        new Sparepart
                        {
                            Id = 1,
                            Name = "Generator",
                            Price = 200.22
                        }
                    }
                },
            };

        }

        private void LoadCustomers()
        {
            customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Nicolai",
                    Surname = "Bjerg",
                    Mail = "min@mail.com",
                    Cars = new ObservableCollection<Car>
                    {
                        new Car
                        {
                            Id = 1,
                            Brand = CarBrand.Ford,
                            Model = "Ka",
                            Plate = "AB 123 456"
                        }
                    }
                },
                new Customer
                {
                    Id = 2,
                    Name = "Morten",
                    Surname = "Nissen",
                    Mail = "hans@mail.com",
                    Cars = new ObservableCollection<Car>
                    {
                        new Car
                        {
                            Id = 2,
                            Brand = CarBrand.BMW,
                            Model = "X5",
                            Plate = "AB 654 321"
                        }
                    }
                },
                new Customer
                {
                    Id = 3,
                    Name = "Kevin",
                    Surname = "Pike",
                    Mail = "pike@mail.com",
                    Cars = new ObservableCollection<Car>
                    {
                        new Car
                        {
                            Id = 3,
                            Brand = CarBrand.VolksWagen,
                            Model = "Polo",
                            Plate = "AB 345 683"
                        }
                    }
                },
            };

            foreach (var customer in customers)
            {
                foreach (var car in customer.Cars)
                {
                    car.Customer = customer;
                }
            }
        }

        public void DeleteTask(Task task)
        {
            tasks.Remove(task);
        }

        public void UpdateTask(Task task)
        {
            Task tasktoUpdate = tasks.Where(t => t.Id == task.Id).FirstOrDefault();

            if (tasktoUpdate != null)
            {
                tasktoUpdate = task;
            }
            else
            {
                tasks.Add(task);
            }
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddCar(Car car)
        {
            Customer customerToGetNewCar = customers.Where(c => c.Id == car.Customer.Id).FirstOrDefault();

            customerToGetNewCar.Cars.Add(car);
        }
    }
}
