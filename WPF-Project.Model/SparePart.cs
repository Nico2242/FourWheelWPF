using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WPF_Project.Model
{
    public class Sparepart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public ObservableCollection<Task> Tasks { get; set; }
    }
}
