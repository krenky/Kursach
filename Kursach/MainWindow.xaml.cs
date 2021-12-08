using Kursach.Context;
using System.Windows;

namespace Kursach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int _currentEngineer = 0;
        public static ApplicationContext _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new ApplicationContext();
        }
    }
}
