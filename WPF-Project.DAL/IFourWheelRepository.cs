using System.Collections.Generic;
using WPF_Project.Model;

namespace WPF_Project.DAL
{
    public interface IFourWheelRepository
    {
        List<Customer> GetCustomers();
        List<Task> GetTasks();
        List<Sparepart> GetSpareparts();
        void UpdateTask(Task task, bool endTask = false);
        void DeleteTask(Task task);
        void AddCustomer(Customer customer);
        void AddCar(Car car);
    }
}