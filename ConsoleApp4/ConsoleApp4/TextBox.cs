using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class TextBox : ConsoleApp4.ControlElement_n, IPushable
    {
        //new field and properties
        public string Text { get; set; } = " ";     
        
        //abstract method
        public override void Display()
        {
            Console.WriteLine($"Caption of the button is - '{Caption}' ");
            Console.WriteLine($"New size of the button is - ({Height},{Width}) ");
        }
        //methods
        public override bool Push()
        {
            ++ClickCount;
            Console.WriteLine("Pointer is set");
            return (true);       
        //Console.ForegroundColor = ConsoleColor.Cyan; // set the color
        //Console.WriteLine($"Button '{Caption}'  has been pressed");
        //Thread.Sleep(1000);// 1 sec. 
        //Console.ResetColor(); // default
        //Console.Beep();         
        }      
        public string EnterText ()
        {
            Console.WriteLine("Enter the text");
            Text = Console.ReadLine();
            return Text;
        }
        public void DoublePush()
        {
            ClickCount += 2;
            Console.WriteLine("Pointer is set");
            Console.WriteLine("Selection set");
            //return true;
        }
        public string CutText ()
        {
            string str = Text;
            Text = "";
            Console.WriteLine("Text is cut and the field is empty");
            return str;
        }
        public void Press ()
        {
            ++ClickCount;
            Console.WriteLine("Pointer is set");
        }
        public void  DoublePress()
        {
            ClickCount += 2;
            Console.WriteLine("Pointer is set");
            Console.WriteLine("Selection set");
        }
    }
}
