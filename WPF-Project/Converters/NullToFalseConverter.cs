using System;
using System.Globalization;
using System.Windows.Data;
using WPF_Project.Model;

namespace WPF_Project.Converters
{
    public class NullToFalseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Customer customer = (Customer)value;

            if (customer != null && customer.Cars.Count > 0)
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
