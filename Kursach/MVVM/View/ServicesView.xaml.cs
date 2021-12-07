﻿using Microsoft.EntityFrameworkCore;
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
    }
}
