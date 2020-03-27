namespace WPF_Project.Messages
{
    public class UpdateListMessage
    {
        public UpdateListMessage(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
