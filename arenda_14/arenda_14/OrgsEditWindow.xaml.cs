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
    /// Interaction logic for OrgsEditWindow.xaml
    /// </summary>
    public partial class OrgsEditWindow : Window
    {
        private Организации editOrg;

        public OrgsEditWindow(Организации edited)
        {
            InitializeComponent();

            this.editOrg = edited;
            this.адресTextBox.Text = edited.Адрес;
            this.банкTextBox.Text = edited.Банк;
            this.бИКБанкаTextBox.Text = edited.БИКБанка;
            this.городTextBox.Text = edited.Город;
            this.кодОрганизацииTextBox.Text = edited.КодОрганизации.ToString();
            this.организацияTextBox.Text = edited.Организация;
            this.организацияКраткоTextBox.Text = edited.ОрганизацияКратко;
            this.почтовыйИндексTextBox.Text = edited.ПочтовыйИндекс;
            this.почтовыйЯщикTextBox.Text = edited.ПочтовыйЯщик;
            this.расчётныйСчётTextBox.Text = edited.РасчётныйСчёт;
            this.телефонTextBox.Text = edited.Телефон;
            this.уНПTextBox.Text = edited.УНП;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource организацииViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("организацииViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // организацииViewSource.Source = [generic data source]
        }
        //ОТМЕНИТЬ РЕДАКТИРОВАНИЕ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
        //СОХРАНИТЬ РЕДАКТИРОВАНИЕ
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.editOrg.Адрес = адресTextBox.Text;
            this.editOrg.Банк = банкTextBox.Text;
            this.editOrg.БИКБанка = бИКБанкаTextBox.Text;
            this.editOrg.Город = городTextBox.Text;
            this.editOrg.КодОрганизации = int.Parse(кодОрганизацииTextBox.Text);
            this.editOrg.Организация = организацияTextBox.Text;
            this.editOrg.ОрганизацияКратко = организацияКраткоTextBox.Text;
            this.editOrg.ПочтовыйИндекс = почтовыйИндексTextBox.Text;
            this.editOrg.ПочтовыйЯщик = почтовыйЯщикTextBox.Text;
            this.editOrg.РасчётныйСчёт = расчётныйСчётTextBox.Text;
            this.editOrg.Телефон = телефонTextBox.Text;
            this.editOrg.УНП = уНПTextBox.Text;

            this.DialogResult = true;

            this.Close();

        }
    }
}
