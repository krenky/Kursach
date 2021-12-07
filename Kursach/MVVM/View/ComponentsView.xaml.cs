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
    /// Логика взаимодействия для ComponentsView.xaml
    /// </summary>
    public partial class ComponentsView : UserControl
    {
        public ComponentsView()
        {
            InitializeComponent();

            MainWindow._context.Components.Load();
            Datagrid_Components.ItemsSource = MainWindow._context.Components.Local.ToBindingList();
        }

        private void Datagrid_Components_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow._context.SaveChanges();
        }
    }
}
