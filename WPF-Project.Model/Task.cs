using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        string description;
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

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
        public ObservableCollection<Sparepart> Spareparts { get; set; }


        #region PROPERTY CHANGED EVENT
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
