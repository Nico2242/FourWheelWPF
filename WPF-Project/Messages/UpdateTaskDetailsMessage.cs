using WPF_Project.Model;

namespace WPF_Project.Messages
{
    public class UpdateTaskDetailsMessage
    {
        public UpdateTaskDetailsMessage(Task task)
        {
            Task = task;
        }

        public Task Task { get; set; }
    }
}
