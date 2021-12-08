using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace Kursach.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ServicesView.xaml
    /// </summary>
    public partial class ServicesView : UserControl
    {
        public ServicesView()
        {
            InitializeComponent();

            MainWindow._context.Services.Load();
            Datagrid_Services.ItemsSource = MainWindow._context.Services.Local.ToBindingList();
        }

        private void Datagrid_Services_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainWindow._context.SaveChanges();
        }

        private void Datagrid_Services_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow._context.SaveChanges();
        }
    }
}
