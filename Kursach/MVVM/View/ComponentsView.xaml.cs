using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;

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
