using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project.Extensions
{
    public static class ListExtension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> coll)
        {
            ObservableCollection<T> result = new ObservableCollection<T>();
            foreach (var item in coll)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
