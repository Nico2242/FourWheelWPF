using System.Collections.Generic;
using WPF_Project.Model;

namespace WPF_Project.Services
{
    public interface IFourWheelDataService
    {
        List<Customer> GetAllCustomers();
        List<Task> GetAllTasks();
        List<Sparepart> GetAllSpareparts();
        void UpdateTask(Task task, bool endTask = false);
        void DeleteTask(Task selectedTask);
        void AddCustomer(Customer Customer);
        void AddCar(Car newCar);
    }
}