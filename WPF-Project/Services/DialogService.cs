using System.Windows;
using WPF_Project.View;

namespace WPF_Project.Services
{
    public class DialogService : IDialogService
    {
        Window taskDetailsWindow = null;
        Window sparpartsWindow = null;

        public DialogService()
        {

        }


        public void CloseTaskDetailsDialog()
        {
            if (taskDetailsWindow != null)
                taskDetailsWindow.Close();
        }

        public void ShowTaskDetailsDialog()
        {
            taskDetailsWindow = new TaskDetailsWindow();
            taskDetailsWindow.Show();
        }

        public void ShowSparepartsWindow()
        {
            sparpartsWindow = new SparepartsWindow();
            sparpartsWindow.Show();
        }

        public void CloseSparepartsWindows()
        {
            if (sparpartsWindow != null)
                sparpartsWindow.Close();
        }
    }
}
