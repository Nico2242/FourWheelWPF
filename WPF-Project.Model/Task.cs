using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project.Model
{
    public class Task : INotifyPropertyChanged
    {
        public int Id { get; set; }

        string start;
        public string Start 
        {
            get => start;
            set
            {
                if (value != start)
                {
                    start = value;
                    if (value != null)
                    {
                        End = "Ongoing";
                    }
                    OnPropertyChanged();
                }
            } 
        }

        string end;
        public string End 
        {
            get => end;
            set
            {
                if (value != end)
                {
                    end = value;
                    OnPropertyChanged();
                }
            } 
        }
        public string Description { get; set; }

        bool status;
        public bool Status 
        {
            get => status;
            set
            {
                if (value != status)
                {
                    status = value;
                    Start = DateTime.Now.ToString("dd/MM/yy HH:mm");
                    OnPropertyChanged();
                }
            }
        }

        public Car Car { get; set; }


        #region PROPERTY CHANGED EVENT
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
