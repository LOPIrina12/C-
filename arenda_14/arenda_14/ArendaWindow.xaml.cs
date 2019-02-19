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
    /// Interaction logic for ArendaWindow.xaml
    /// </summary>
    public partial class ArendaWindow : Window
    {
        CollectionViewSource arendaSource;

        public ArendaWindow()
        {
            InitializeComponent();
            arendaSource = (CollectionViewSource)FindResource("арендаViewSource");
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.Context.Аренда.Load();
            arendaSource.Source = App.Context.Аренда.Local;

            System.Windows.Data.CollectionViewSource арендаViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("арендаViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // арендаViewSource.Source = [generic data source]
        }
        //обработчик для кнопки "УДАЛИТЬ"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Получаем объект класса Аренда, соответствующий выделенной записи в DataGrid
            Аренда selectedArenda = арендаDataGrid.SelectedItem as Аренда;

            //Показываем MessageBox с вопросом о подтверждении удаления
            MessageBoxResult confirmDelete = MessageBox.Show(
                "Удалить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //Если пользователь подтвердил удаление, то
            if (confirmDelete == MessageBoxResult.Yes)
            {
                //Удаляем выбранный объект
                App.Context.Аренда.Remove(selectedArenda);
                //Обновляем отображения таблицы
                arendaSource.View.Refresh();
                //Сохраняем изменения
                App.Context.SaveChanges();
            }
        }
        //Обработчик для кнопки ДОБАВИТЬ АРЕНДУ
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Создаем окно AddArendaWindow
            AddArendaWindow add = new AddArendaWindow();

            //Запускаем его в модальном режиме и ожидаем возврата значения
            //которое придет сюда, когда модальное окно будет закрыто
            //тип - nullable bool

            bool? wasadd = add.ShowDialog();
            //Если принятое значение true
            if(wasadd == true)
            {
                //Обновляем отображенные данные таблицы dataGrid,
                //чтобы они отобразили изменения DbSet

                arendaSource.View.Refresh();
            }

        }

        //обработчик для кнопки РЕДАКТИРОВАТЬ организацию
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Аренда selectedArenda = арендаDataGrid.SelectedItem as Аренда;

            ArendaEditDialog add = new ArendaEditDialog(selectedArenda);

            bool? wasAdded = add.ShowDialog();

            if(wasAdded == true)
            {
                arendaSource.View.Refresh();

                App.Context.SaveChanges();
            }
        }
    }
}
