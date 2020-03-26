using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Project.View
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void CustomerAdmin_Click(object sender, RoutedEventArgs e)
        {
            CustomerAdminWindow customerAdminWindow = new CustomerAdminWindow();
            customerAdminWindow.Show();
        }

        private void TaskAdmin_Click(object sender, RoutedEventArgs e)
        {
            TaskAdminWindow taskAdminWindow = new TaskAdminWindow();
            taskAdminWindow.Show();
        }
    }
}
