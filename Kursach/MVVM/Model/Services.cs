using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Kursach.MVVM.Model
{
    public class Service : INotifyPropertyChanged
    {
        private string name;
        private int price;
        private ObservableCollection<Contract> contracts;

        public int Id { get; set; }
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public ObservableCollection<Contract> Contracts 
        { 
            get 
            {
                return contracts;
            } 
            set 
            { 
                contracts = value;
                OnPropertyChanged("Contracts");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
