using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project.Model
{
    public enum CarBrand
    {
        None,
        Ford,
        Audi,
        VolksWagen,
        BMW,
        Volvo,
        Porsche
    }

    public class Car
    {
        public int Id { get; set; }
        public CarBrand Brand { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }
    }
}
