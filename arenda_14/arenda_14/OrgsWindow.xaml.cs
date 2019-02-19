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
    /// Interaction logic for OrgsWindow.xaml
    /// </summary>
    public partial class OrgsWindow : Window
    {
        CollectionViewSource orgsSource;

        public OrgsWindow()
        {
            InitializeComponent();

            orgsSource = (CollectionViewSource)FindResource("организацииViewSource");

            DataContext = this;
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            App.Context.Организации.Load();

            orgsSource.Source = App.Context.Организации.Local;
           
        }
        //обработчик для кнопки ДОБАВИТЬ ОРГАНИЗАЦИЮ

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrgsAddWindow add = new OrgsAddWindow();

            bool? wasAdded = add.ShowDialog();
            if (wasAdded == true)
            {
                orgsSource.View.Refresh();
            }
        }

        // обработчик для кнопки "УДАЛИТЬ"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Организации selectedOrg = организацииDataGrid.SelectedItem as Организации;

            MessageBoxResult confirmdelete = MessageBox.Show(
                "Удалить строку?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(confirmdelete == MessageBoxResult.Yes)
            {
                App.Context.Организации.Remove(selectedOrg);
                orgsSource.View.Refresh();
                App.Context.SaveChanges();
            }
        }
        //обработчик для кнопки РЕДАКТИРОВАТЬ ОРГАНИЗАЦИИ
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Организации selectedOrg = организацииDataGrid.SelectedItem as Организации;

            OrgsEditWindow add = new OrgsEditWindow(selectedOrg);
            bool? wasAdded = add.ShowDialog();
            if (wasAdded == true)
            {
                orgsSource.View.Refresh();
                App.Context.SaveChanges();
            }
        }
    }
}
