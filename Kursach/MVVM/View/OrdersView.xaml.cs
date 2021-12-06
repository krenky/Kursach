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
    /// Логика взаимодействия для OrdersView.xaml
    /// </summary>
    public partial class OrdersView : UserControl
    {
        ApplicationContext _context = new ApplicationContext();
        public OrdersView()
        {
            InitializeComponent();

            _context.Contracts.Load();
            Datagrid_Contract.ItemsSource = _context.Contracts.Local.ToBindingList();
        }

        private void Datagrid_Contract_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_AddContract_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewContract_Initialized(object sender, EventArgs e)
        {
        }

        private void Datagrid_Contract_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
            
        }
    }
}
