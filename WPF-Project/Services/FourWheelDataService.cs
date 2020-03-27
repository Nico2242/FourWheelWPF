using System.Collections.Generic;
using WPF_Project.DAL;
using WPF_Project.Model;

namespace WPF_Project.Services
{
    public class FourWheelDataService : IFourWheelDataService
    {
        IFourWheelRepository repo;

        public FourWheelDataService(IFourWheelRepository repository)
        {
            this.repo = repository;
        }

        public List<Customer> GetAllCustomers()
        {
            return repo.GetCustomers();
        }

        public List<Task> GetAllTasks()
        {
            return repo.GetTasks();
        }
        public List<Sparepart> GetAllSpareparts()
        {
            return repo.GetSpareparts();
        }

        public void UpdateTask(Task task, bool endTask = false)
        {
            repo.UpdateTask(task, endTask);
        }

        public void DeleteTask(Task task)
        {
            repo.DeleteTask(task);
        }

        public void AddCustomer(Customer customer)
        {
            repo.AddCustomer(customer);
        }

        public void AddCar(Car car)
        {
            repo.AddCar(car);
        }

    }
}
