using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Kursach.MVVM.Model
{
    public class Contract : INotifyPropertyChanged
    {
        ObservableCollection<Component> components = new ObservableCollection<Component>();
        ObservableCollection<Service> services = new ObservableCollection<Service>();
        private string model;
        private string description;
        private int engineerId;
        private Engineer engineer;
        private string status;
        private int clientId;
        private Client client;
        private DateTime dateAcceptance = DateTime.Now;
        private DateTime dateLimitation;

        public int Id { get; set; }
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        public int EngineerId
        {
            get
            {
                return engineerId;
            }
            set
            {
                engineerId = value;
                OnPropertyChanged("EngineerId");
            }
        }
        public Engineer Engineer
        {
            get { return engineer; }
            set
            {
                engineer = value;
                OnPropertyChanged("Engineer");
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }
        public ObservableCollection<Component> Components
        {
            get
            {
                return components;
            }
            set
            {
                components = value;
                OnPropertyChanged("Components");
            }
        }
        public ObservableCollection<Service> Services
        {
            get
            {
                return services;
            }
            set
            {
                services = value;
                OnPropertyChanged("Services");
            }
        }
        public int ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
                OnPropertyChanged("ClientId");
            }
        }
        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
                OnPropertyChanged("Client");
            }
        }
        public int Price
        {
            get
            {
                return Components.Sum(o => o.Price) + Services.Sum(o => o.Price);
            }
        }
        public DateTime DateAcceptance
        {
            get
            {
                return dateAcceptance;
            }
            set
            {
                dateAcceptance = DateTime.Now;
                OnPropertyChanged("DateAcceptance");
            }
        }
        public DateTime DateLimitation
        {
            get
            {
                return dateLimitation;
            }
            set
            {
                dateLimitation = value;
                OnPropertyChanged("DateLimitation");
            }
        }
        public TimeSpan DateLeft
        {
            get
            {
                return DateLimitation - DateAcceptance;
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
