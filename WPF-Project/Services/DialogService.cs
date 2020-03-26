using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Project.View;

namespace WPF_Project.Services
{
    public class DialogService : IDialogService
    {
        Window taskDetailsWindow = null;

        public DialogService()
        {

        }


        public void CloseTaskDetailsDialog()
        {
            throw new NotImplementedException();
        }

        public void ShowTaskDetailsDialog()
        {
            taskDetailsWindow = new TaskDetailsWindow();
            taskDetailsWindow.Show();
        }
    }
}
