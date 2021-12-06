using Kursach.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ClientsView.xaml
    /// </summary>
    public partial class ClientsView : UserControl
    {
        ApplicationContext _context = new ApplicationContext();
        public ClientsView()
        {
            InitializeComponent();

            _context.Clients.Load();
            Datagrid_Clients.ItemsSource = _context.Clients.Local.ToBindingList();
        }

        private void Datagrid_Clients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.SaveChanges();
        }
    }
}
