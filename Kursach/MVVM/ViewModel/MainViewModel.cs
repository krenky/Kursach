using Kursach.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand OrdersViewCommand { get; set; }
        public RelayCommand ClientsViewCommand { get; set; }
        public RelayCommand OptionsViewCommand { get; set; }
        public RelayCommand ComponentsViewCommand { get; set; }
        public RelayCommand ServicesViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public OrdersViewModel OrdersVM { get; set; }
        public ClientsViewModel ClientsVM { get; set; }
        public OptionsViewModel OptionsVM { get; set; }
        public ComponentsViewModel ComponentsVM { get; set; }
        public ServicesViewModel ServicesVM { get; set; }

        private object _currentView;

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            OrdersVM = new OrdersViewModel();
            ClientsVM = new ClientsViewModel();
            OptionsVM = new OptionsViewModel();
            ComponentsVM = new ComponentsViewModel();
            ServicesVM = new ServicesViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            OrdersViewCommand = new RelayCommand(o =>
            {
                CurrentView = OrdersVM;
            });

            ClientsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClientsVM;
            });

            OptionsViewCommand = new RelayCommand(o =>
            {
                CurrentView = OptionsVM;
            });

            ComponentsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ComponentsVM;
            });

            ServicesViewCommand = new RelayCommand(o =>
            {
                CurrentView = ServicesVM;
            });
        }

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

    }
}
