using Kursach.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Controls;

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
                .Where(a => a.Status == "В работе")
                .Where(a => a.EngineerId == MainWindow._currentEngineer)
                .ToList()
                .Count()
                .ToString();
            TextBlock_CountAllContracts.Text = "Кол-во заказов: " + MainWindow._context.Contracts
                .Where(a => a.EngineerId == MainWindow._currentEngineer)
                .ToList()
                .Count()
                .ToString();
            Engineer engineer = MainWindow._context.Engineers.Where(a => a.Id == MainWindow._currentEngineer).FirstOrDefault();
            if(engineer != null)
                TextBlock_NameEngineer.Text = engineer.FullName;
            TextBlock_Components.Text = MainWindow._context.Components.Count().ToString();
            TextBlock_Money.Text = MainWindow._context.Contracts
                .Include(a => a.Components)
                .Include(a => a.Services)
                .Where(a => a.Status == "Готово")
                .ToList<Contract>()
                .Sum(a => a.Price).ToString();
        }
    }
}
