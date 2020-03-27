using System.Collections.ObjectModel;

namespace WPF_Project.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }

        public ObservableCollection<Car> Cars { get; set; }
    }
}
