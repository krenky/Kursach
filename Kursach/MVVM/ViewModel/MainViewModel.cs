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

        public HomeViewModel HomeVM { get; set; }
        public OrdersViewModel OrdersVM { get; set; }
        public ClientsViewModel ClientsVM { get; set; }

        private object _currentView;

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            OrdersVM = new OrdersViewModel();
            ClientsVM = new ClientsViewModel();
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
