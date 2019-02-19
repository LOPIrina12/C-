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
    /// Interaction logic for OrgsAddWindow.xaml
    /// </summary>
    public partial class OrgsAddWindow : Window
    {
        public OrgsAddWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource организацииViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("организацииViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // организацииViewSource.Source = [generic data source]
        }
        //ОБРАБОТЧИК ДЛЯ КНОПКИ ОТМЕНИТЬ ДОБАВЛЕНИЕ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;

            this.Close();
        }
        //обработчик для кнопки СОХРАНИТЬ ДОБАВЛЕНИЕ ОРГАНИЗАЦИИ

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Организации newOrg = new Организации();

        
            newOrg.КодОрганизации = int.Parse(кодОрганизацииTextBox.Text);
            newOrg.Организация = организацияTextBox.Text;
            newOrg.ОрганизацияКратко = организацияКраткоTextBox.Text;
            newOrg.УНП = уНПTextBox.Text;
            newOrg.БИКБанка = бИКБанкаTextBox.Text;
            newOrg.Банк = банкTextBox.Text;
            newOrg.РасчётныйСчёт = расчётныйСчётTextBox.Text;
            newOrg.ПочтовыйИндекс = почтовыйИндексTextBox.Text;
            newOrg.Город = городTextBox.Text;
            newOrg.Адрес = адресTextBox.Text;
            newOrg.ПочтовыйЯщик = почтовыйЯщикTextBox.Text;
           
            newOrg.Телефон = телефонTextBox.Text;
            

            App.Context.Организации.Add(newOrg);
            App.Context.SaveChanges();
            this.DialogResult = true;
            this.Close();
        }
    }
}
