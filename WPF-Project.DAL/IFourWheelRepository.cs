using System.Collections.Generic;
using WPF_Project.Model;

namespace WPF_Project.DAL
{
    public interface IFourWheelRepository
    {
        List<Customer> GetCustomers();
        List<Task> GetTasks();
        void UpdateTask(Task task);
        void DeleteTask(Task task);
    }
}