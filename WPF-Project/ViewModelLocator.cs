using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Project.DAL;
using WPF_Project.Services;
using WPF_Project.ViewModel;

namespace WPF_Project
{
    public class ViewModelLocator
    {
        private static IDialogService dialogService = new DialogService();
        private static IFourWheelDataService dataService = new FourWheelDataService(new FourWheelRepository());

        public static CustomerAdminViewModel CustomerAdminViewModel { get; } = new CustomerAdminViewModel(dataService, dialogService);
        public static TaskAdminViewModel TaskAdminViewModel { get; } = new TaskAdminViewModel(dataService, dialogService);
        public static TaskDetailsViewModel TaskDetailsViewModel { get; } = new TaskDetailsViewModel(dataService, dialogService);
    }
}
