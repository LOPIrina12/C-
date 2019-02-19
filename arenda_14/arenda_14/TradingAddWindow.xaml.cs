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

namespace arenda_14
{
    /// <summary>
    /// Interaction logic for TradingAddWindow.xaml
    /// </summary>
    public partial class TradingAddWindow : Window
    {
        public TradingAddWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource торговыеМестаViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("торговыеМестаViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // торговыеМестаViewSource.Source = [generic data source]
        }
        //обработчик для кнопки ОТМЕНИТЬ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        //обработчик для кнопки СОХРАНИТЬ ДОБАВЛЕНИЕ
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ТорговыеМеста newtrading = new ТорговыеМеста();

            newtrading.КодТорговогоМеста = int.Parse(кодТорговогоМестаTextBox.Text);
            newtrading.НомерТорговогоМеста = номерТорговогоМестаTextBox.Text;
            newtrading.Этаж = short.Parse(этажTextBox.Text);
            newtrading.Площадь = float.Parse(площадьTextBox.Text);
            newtrading.ЕдИзм = едИзмTextBox.Text;
            newtrading.Ставка = float.Parse(ставкаTextBox.Text);
            newtrading.ЕдИзм_ = едИзм_TextBox.Text;
            newtrading.Арендовано = арендованоCheckBox.IsChecked;

            App.Context.ТорговыеМеста.Add(newtrading);

            App.Context.SaveChanges();

            this.DialogResult = true;

            this.Close();

        }
    }
}
