using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Project.ViewModel;

namespace WPF_Project
{
    public class ViewModelLocator
    {
        public static CustomerAdminWindowViewModel CustomerAdminWindowViewModel { get; } = new CustomerAdminWindowViewModel();
        public static TaskAdminWindowViewModel TaskAdminWindowViewModel { get; } = new TaskAdminWindowViewModel();
    }
}
