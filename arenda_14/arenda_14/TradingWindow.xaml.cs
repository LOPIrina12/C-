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
using System.Windows.Shapes;
using System.Data.Entity;

namespace arenda_14
{
    /// <summary>
    /// Interaction logic for TradingWindow.xaml
    /// </summary>
    public partial class TradingWindow : Window
    {
        CollectionViewSource tradingSource;

        public TradingWindow()
        {
            InitializeComponent();
            tradingSource = (CollectionViewSource)FindResource("торговыеМестаViewSource");
             DataContext = this;
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.Context.ТорговыеМеста.Load();
            tradingSource.Source = App.Context.ТорговыеМеста.Local;          
        }

        //обработчик для кнопки ДОБАВИТЬ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TradingAddWindow add = new TradingAddWindow();

            bool? wasAdded = add.ShowDialog();

            if (wasAdded == true)
            {
                tradingSource.View.Refresh();
            }
        }
        //обработчик для кнопки УДАЛИТЬ ТОРГОВОЕ МЕСТО
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ТорговыеМеста selectedTrading = торговыеМестаDataGrid.SelectedItem as ТорговыеМеста;

            MessageBoxResult confirmDelete = MessageBox.Show(
                "Удалить запись?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(confirmDelete ==MessageBoxResult.Yes)
            {
                App.Context.ТорговыеМеста.Remove(selectedTrading);

                tradingSource.View.Refresh();
                App.Context.SaveChanges();
            }
        }
        //обработчик для кнопки РЕДАКТИРОВАТЬ

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ТорговыеМеста selectedTrading = торговыеМестаDataGrid.SelectedItem as ТорговыеМеста;

            EditTradingWindow add = new EditTradingWindow(selectedTrading);

            bool? wasAdded = add.ShowDialog();

            if (wasAdded == true)
            {
                tradingSource.View.Refresh();
                App.Context.SaveChanges();
            }

        }
    }
}
