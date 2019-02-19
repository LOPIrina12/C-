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

namespace arenda_14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //ОБРАБОТЧИК ДЛЯ КНОПКИ "АРЕНДА"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ArendaWindow arenda = new ArendaWindow();

            arenda.Show();
        }

        //обработчик для кнопки "ТОРГОВЫЕ МЕСТА"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TradingWindow trading = new TradingWindow();

            trading.Show();
        }

        //обработчик для кнопки "ОРГАНИЗАЦИИ"
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            OrgsWindow orgs = new OrgsWindow();
            orgs.Show();
        }
    }
}
