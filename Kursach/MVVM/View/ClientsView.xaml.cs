using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;

namespace Kursach.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ClientsView.xaml
    /// </summary>
    public partial class ClientsView : UserControl
    {
        public ClientsView()
        {
            InitializeComponent();
            MainWindow._context.Clients.Load();
            Datagrid_Clients.ItemsSource = MainWindow._context.Clients.Local.ToBindingList();
        }

        private void Datagrid_Clients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow._context.SaveChanges();
        }
    }
}
