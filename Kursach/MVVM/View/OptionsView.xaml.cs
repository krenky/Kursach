using Kursach.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Kursach.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для OptionsView.xaml
    /// </summary>
    public partial class OptionsView : UserControl
    {
        public OptionsView()
        {
            InitializeComponent();
            MainWindow._context.Engineers.Load();
            ComboBox_Engineer.ItemsSource = MainWindow._context.Engineers.Local.ToBindingList();
        }

        private void Button_AddEngineer_Click(object sender, RoutedEventArgs e)
        {
            Engineer engineer = new Engineer { FullName = TextBox_Name.Text, Login = TextBox_Login.Text };
            MainWindow._context.Engineers.Add(engineer);
            MainWindow._context.SaveChanges();
        }

        private void ComboBox_Engineer_DropDownClosed(object sender, EventArgs e)
        {
            Engineer engineer = (Engineer)ComboBox_Engineer.SelectedItem;
            if(engineer != null)
                MainWindow._currentEngineer = engineer.Id;
        }
    }
}
