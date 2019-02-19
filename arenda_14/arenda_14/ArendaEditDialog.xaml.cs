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
    /// Interaction logic for ArendaEditDialog.xaml
    /// </summary>
    public partial class ArendaEditDialog : Window

    {
        private Аренда editedArenda;

        public ArendaEditDialog(Аренда edited)
        {

            InitializeComponent();

            this.editedArenda = edited;
            this.кодУчётаАрендыTextBox.Text = edited.КодУчётаАренды.ToString();
            this.кодОрганизацииTextBox.Text = edited.КодОрганизации.ToString();
            this.кодТорговогоМестаTextBox.Text = edited.КодТорговогоМеста.ToString();
            this.договорTextBox.Text = edited.Договор;
            this.датаЗаключенияДоговораDatePicker.SelectedDate = (DateTime)edited.ДатаЗаключенияДоговора;
            this.датаОкончанияДоговораDatePicker.SelectedDate = (DateTime)edited.ДатаОкончанияДоговора;
            this.оплаченоCheckBox.IsChecked = edited.Оплачено;
            this.датаЗачисленияDatePicker.SelectedDate = (DateTime)edited.ДатаЗачисления;
            this.оплатаПоДоговоруDatePicker.SelectedDate = (DateTime)edited.ОплатаПоДоговору;
            this.суммаОплатыTextBox.Text = edited.СуммаОплаты.ToString();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //arenda_14.ARENDA_lastDataSet aRENDA_lastDataSet = ((arenda_14.ARENDA_lastDataSet)(this.FindResource("aRENDA_lastDataSet")));
            //// Load data into the table Аренда. You can modify this code as needed.
            //arenda_14.ARENDA_lastDataSetTableAdapters.АрендаTableAdapter aRENDA_lastDataSetАрендаTableAdapter = new arenda_14.ARENDA_lastDataSetTableAdapters.АрендаTableAdapter();
            //aRENDA_lastDataSetАрендаTableAdapter.Fill(aRENDA_lastDataSet.Аренда);
            //System.Windows.Data.CollectionViewSource арендаViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("арендаViewSource")));
            //арендаViewSource.View.MoveCurrentToFirst();
          //  System.Windows.Data.CollectionViewSource арендаViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("арендаViewSource1")));
            // Load data by setting the CollectionViewSource.Source property:
            // арендаViewSource1.Source = [generic data source]
        }
        //ОБРАБОТЧИК ДЛЯ КНОПКИ ОТМЕНИТЬ РЕДАКТИРОВАНИЕ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
        //обработчик для кпопки СОХРАНИТЬ РЕДАКТИРОВАНИЕ
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //переносим все значения из текстовых полей в свойста
            //сохраненного редактируемого объекта editArenda

            this.editedArenda.КодУчётаАренды = int.Parse(кодУчётаАрендыTextBox.Text);
            this.editedArenda.КодОрганизации = int.Parse(кодОрганизацииTextBox.Text);
            this.editedArenda.КодТорговогоМеста = int.Parse(кодТорговогоМестаTextBox.Text);
            this.editedArenda.Договор = договорTextBox.Text;
            this.editedArenda.ДатаЗаключенияДоговора = (DateTime)датаЗаключенияДоговораDatePicker.SelectedDate;
            this.editedArenda.ДатаОкончанияДоговора = (DateTime)датаОкончанияДоговораDatePicker.SelectedDate;
            this.editedArenda.Оплачено = оплаченоCheckBox.IsChecked;
            this.editedArenda.ДатаЗачисления = (DateTime)датаЗачисленияDatePicker.SelectedDate;
            this.editedArenda.ОплатаПоДоговору = (DateTime)оплатаПоДоговоруDatePicker.SelectedDate;
            this.editedArenda.СуммаОплаты = int.Parse(суммаОплатыTextBox.Text);

            //возвращаемое значение true

            this.DialogResult = true;

            //закрываем окно

            this.Close();
        
        }
    }
}
