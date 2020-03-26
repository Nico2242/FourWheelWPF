using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
