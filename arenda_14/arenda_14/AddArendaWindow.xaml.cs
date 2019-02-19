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
    /// Interaction logic for AddArendaWindow.xaml
    /// </summary>
    public partial class AddArendaWindow : Window
    {
        CollectionViewSource orgsSourse;

        CollectionViewSource tradingSourse;

        public AddArendaWindow()
        {
            InitializeComponent();
            orgsSourse = (CollectionViewSource)FindResource("организацииViewSource");
            DataContext = this;
            //InitializeComponent();
            tradingSourse = (CollectionViewSource)FindResource("торговыеМестаViewSource");
            DataContext = this;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            App.Context.Организации.Load();

            orgsSourse.Source = App.Context.Организации.Local;

            App.Context.ТорговыеМеста.Load();

            tradingSourse.Source = App.Context.ТорговыеМеста.Local;



            //arenda_14.ARENDA_lastDataSet aRENDA_lastDataSet = ((arenda_14.ARENDA_lastDataSet)(this.FindResource("aRENDA_lastDataSet")));
            //// Load data into the table Аренда. You can modify this code as needed.
            //arenda_14.ARENDA_lastDataSetTableAdapters.АрендаTableAdapter aRENDA_lastDataSetАрендаTableAdapter = new arenda_14.ARENDA_lastDataSetTableAdapters.АрендаTableAdapter();
            //aRENDA_lastDataSetАрендаTableAdapter.Fill(aRENDA_lastDataSet.Аренда);
            //System.Windows.Data.CollectionViewSource арендаViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("арендаViewSource")));
            //арендаViewSource.View.MoveCurrentToFirst();


           
        }


        //ОБРАБОТЧИК ДЛЯ КНОПКИ ОТМЕНИТЬ ДОБАВЛЕНИЕ АРЕНДЫ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        //Обработчик для кнопки СОХРАНИТЬ ДОБАВЛЕНИЕ АРЕНДЫ
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Создаем новый объект класса модели Аренда - создаем новую запись для БД
            Аренда newArenda = new Аренда();

            //Переносим информацию из текстовых полей в свойства созданного объекта
            newArenda.КодУчётаАренды = int.Parse(кодУчётаАрендыTextBox.Text);
            newArenda.КодОрганизации = int.Parse(кодОрганизацииTextBox.Text);
            newArenda.КодТорговогоМеста = int.Parse(кодТорговогоМестаTextBox.Text);
            newArenda.Договор = договорTextBox.Text;
            newArenda.ДатаЗаключенияДоговора = (DateTime)датаЗаключенияДоговораDatePicker.SelectedDate;
            newArenda.ДатаОкончанияДоговора = (DateTime)датаОкончанияДоговораDatePicker.SelectedDate;
            newArenda.Оплачено = оплаченоCheckBox.IsChecked;
            newArenda.ДатаЗачисления = (DateTime)датаЗачисленияDatePicker.SelectedDate;
            newArenda.ОплатаПоДоговору = (DateTime)оплатаПоДоговоруDatePicker.SelectedDate;
            newArenda.СуммаОплаты = int.Parse(суммаОплатыTextBox.Text);

            //Добавляем методом ADD новый объект Аренда newArenda в DBSet аренда
            App.Context.Аренда.Add(newArenda);
            //Сохраняем локальное изменение DbSet в реальную БД
            App.Context.SaveChanges();
            //Возвращаемое значение = true
            this.DialogResult = true;
            //Закрываем окно
            this.Close();

        }

        private void организацииDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
