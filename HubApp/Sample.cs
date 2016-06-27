using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubApp
{
    class Sample : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (value != this.name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }

            }
        }

        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
