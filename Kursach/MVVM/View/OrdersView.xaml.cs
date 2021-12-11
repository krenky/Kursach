using Kursach.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Kursach.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для OrdersView.xaml
    /// </summary>
    public partial class OrdersView : UserControl
    {
        public OrdersView()
        {
            InitializeComponent();

            MainWindow._context.Contracts.Include(a => a.Components).Include(s =>s.Services).Load();
            MainWindow._context.Clients.Load();
            MainWindow._context.Engineers.Load();
            Datagrid_Contract.ItemsSource = MainWindow._context.Contracts.Local.ToBindingList();
            DataGrid_ComboBox_Clients.ItemsSource = MainWindow._context.Clients.Local.ToBindingList();
            DataGrid_ComboBox_Status.ItemsSource = new List<string> { "Готово", "В работе"};
            DataGrid_ComboBox_Engineer.ItemsSource = MainWindow._context.Engineers.Local.ToBindingList();
            Combobox_ServicesOrComponent.ItemsSource = new List<string> { "Services", "Component" };
        }

        private void Datagrid_Contract_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_AddContract_Click(object sender, RoutedEventArgs e)
        {
            Contract contract = (Contract)Datagrid_Contract.SelectedItem;
            contract = MainWindow._context.Contracts.Find(contract.Id);
            if ((string)Combobox_ServicesOrComponent.SelectedItem == "Services")
            {
                contract.Services.Add(Combobox_ServicesComponent.SelectedItem as Service);
            }

            if ((string)Combobox_ServicesOrComponent.SelectedItem == "Component")
            {
                contract.Components.Add(Combobox_ServicesComponent.SelectedItem as Component);
            }
            MainWindow._context.SaveChanges();
        }

        private void ViewContract_Initialized(object sender, EventArgs e)
        {
        }

        private void Datagrid_Contract_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                MainWindow._context.SaveChanges();
                Contract contract = Datagrid_Contract.SelectedItem as Contract;

                TextBlock_Day.Text = contract == null ? "0":((int)contract.DateLeft.TotalDays).ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }
            
        }

        private void Combobox_ServicesOrComponent_DropDownClosed(object sender, EventArgs e)
        {
            if((string)Combobox_ServicesOrComponent.SelectedItem == "Services")
            {
                MainWindow._context.Services.Load();
                Combobox_ServicesComponent.ItemsSource = MainWindow._context.Services.Local.ToBindingList();
            }
            if ((string)Combobox_ServicesOrComponent.SelectedItem == "Component")
            {
                MainWindow._context.Components.Load();
                Combobox_ServicesComponent.ItemsSource = MainWindow._context.Components.Local.ToBindingList();
            }
        }

        private void Button_DeleteContract_Click(object sender, RoutedEventArgs e)
        {
            Contract contract = (Contract)Datagrid_Contract.SelectedItem;
            contract = MainWindow._context.Contracts.Find(contract.Id);
            if ((string)Combobox_ServicesOrComponent.SelectedItem == "Services")
            {
                contract.Services.Remove(Combobox_ServicesComponent.SelectedItem as Service);
            }

            if ((string)Combobox_ServicesOrComponent.SelectedItem == "Component")
            {
                contract.Components.Remove(Combobox_ServicesComponent.SelectedItem as Component);
            }
            MainWindow._context.SaveChanges();
        }
    }
}
