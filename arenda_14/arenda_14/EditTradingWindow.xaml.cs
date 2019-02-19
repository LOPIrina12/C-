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
    /// Interaction logic for EditTradingWindow.xaml
    /// </summary>
    public partial class EditTradingWindow : Window
    {
        private ТорговыеМеста editedTrading;

        public EditTradingWindow(ТорговыеМеста edited)
        {
            InitializeComponent();
            //Сохраняем редактируемый отбъект в приватное поле
            this.editedTrading = edited;

            this.арендованоCheckBox.IsChecked = edited.Арендовано;
            this.едИзмTextBox.Text = edited.ЕдИзм;
            this.едИзм_TextBox.Text = edited.ЕдИзм_;
            this.кодТорговогоМестаTextBox.Text = edited.КодТорговогоМеста.ToString();
            this.номерТорговогоМестаTextBox.Text = edited.НомерТорговогоМеста;
            this.площадьTextBox.Text = edited.Площадь.ToString();
            this.ставкаTextBox.Text = edited.Ставка.ToString();
            this.этажTextBox.Text = edited.Этаж.ToString();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource торговыеМестаViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("торговыеМестаViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // торговыеМестаViewSource.Source = [generic data source]
        }
        //обработчик для кнопки ОТМЕНИТЬ РЕДАКТИРОВАНИЕ

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
        //обработчик для кнопки СОХРАНИТЬ РЕДАКТИРОВАНИЕ

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.editedTrading.Арендовано = арендованоCheckBox.IsChecked;
            this.editedTrading.ЕдИзм = едИзмTextBox.Text;
            this.editedTrading.ЕдИзм_ = едИзм_TextBox.Text;
            this.editedTrading.КодТорговогоМеста = int.Parse(кодТорговогоМестаTextBox.Text);
            this.editedTrading.НомерТорговогоМеста = номерТорговогоМестаTextBox.Text;
            this.editedTrading.Площадь = float.Parse(площадьTextBox.Text);
            this.editedTrading.Ставка = float.Parse(ставкаTextBox.Text);
            this.editedTrading.Этаж = short.Parse(этажTextBox.Text);

            this.DialogResult = true;

            this.Close();

        }
    }
}
