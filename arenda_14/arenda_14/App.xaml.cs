using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace arenda_14
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ARENDA_lastEntities Context;

        void Application_Start (object sender, StartupEventArgs e)
        {
            Context = new ARENDA_lastEntities();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
