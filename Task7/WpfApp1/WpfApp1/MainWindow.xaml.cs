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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftnum = "";
        string rightnum = "";
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        // event handler
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //get the content from the sender
            string str = (string)((Button)e.OriginalSource).Content;

            //add info to the BoxText
            boxtext.Text += str;

            int number;

            //transformation string to int. 
            bool result = Int32.TryParse(str, out number);

            //if the number was entered
            if (result == true)
            {
                //if there is no operation
                if (operation == "")
                {
                    leftnum += str;
                }
                else
                {
                    rightnum += str;
                }
            }

            //if something was entered but not a number
            else
            {
                if(str == "=")
                {
                    //Call the method to update the right number

                    UpDate();

                    boxtext.Text += rightnum;
                    operation = "";
                }
                else if (str == "CLEAR")
                {
                    leftnum = "";
                    operation = "";
                    rightnum = "";
                    boxtext.Text = "";
                }
                else
                {
                    if (rightnum != "")
                    {
                        UpDate();
                        leftnum = rightnum;
                        rightnum = "";
                    }
                }
            }


        }

        private void UpDate ()
        {
            int a = Int32.Parse(leftnum);
            int b = Int32.Parse(rightnum);

            switch (operation)
            {
                case "+":
                    rightnum = (a + b).ToString();
                    break;
                case "-":
                    rightnum = (a - b).ToString();
                    break;
                case "*":
                    rightnum = (a * b).ToString();
                    break;
                case "/":
                    rightnum = (a / b).ToString();
                    break;
            }
        }

       
    }

}

      


    
