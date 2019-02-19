using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    public class CheckBox : ConsoleApp4.ControlElement_n
    {
        //field and property
        public bool Checked { get; set; } = false;

        //constructor
        public CheckBox(string caption)
        {
            Caption = caption;
        }
           

        //methods
        public override bool Push()
        {
            ++ClickCount;
            SetChecked();
            return true;
        }

        public bool SetChecked()
        {
            Checked = !Checked;
            if (Checked == true)
            {
                Console.WriteLine("Marked as chosen");
            }
            else
            {
                Console.WriteLine("Marked as unchosen");
            }
            return Checked;
        }

        //abstract method
        public override void Display()
        {
            Console.WriteLine($"Caption of the button is - '{Caption}' ");
            Console.WriteLine($"New size of the button is - ({Height};{Width}) ");
        }

        public override string ToString()
        {

            return "CheckBox " + this.Caption;
        }

    }
}
