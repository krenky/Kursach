using Kursach.MVVM.Model;
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
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            TextBlock_CountContracts.Text = MainWindow._context.Contracts
                .Where(a => a.EngineerId == MainWindow._currentEngineer)
                .ToList()
                .Count()
                .ToString();
            Engineer engineer = MainWindow._context.Engineers.Where(a => a.Id == MainWindow._currentEngineer).FirstOrDefault();
            if(engineer != null)
                TextBlock_NameEngineer.Text = engineer.FullName;

        }
    }
}
