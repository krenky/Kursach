using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Kursach.MVVM.Model
{
    public class Engineer : INotifyPropertyChanged
    {
        private string fullName;
        private string login;
        private string? password;
        private ObservableCollection<Contract> contracts;

        public int Id { get; set; }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }
        public string? Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
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
