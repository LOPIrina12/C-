using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class RoundButton : ConsoleApp4.Button, IScalable   
    {
        //abstract method
        public override void Display()
        {
            Console.WriteLine($"Caption of the button is - '{Caption}' ");
            Console.WriteLine($"New size of the button is - ({Height},{Width}) ");
        }
        //field and property
        public bool Available = false;       
        //method
        public bool SetAvaliable (bool Checked)
        {
            if (Checked == true)
            {
                Available = true;
                Console.WriteLine("RoundButton is available. Go on!");
            }
            else
            {
                Console.WriteLine("RoundButton is unavailable. Make a choice to continue!");
            }
            return Available;
        }
        public override bool Push ()
        {           
                ++ClickCount;
                Console.WriteLine("RoundButton has been pressed");                            
            return true;
        }

        ////fields and properties

        public string Caption_n { get; set; }
        public float Height_n { get; set; }
        public float Width_n { get; set; }
        public int Top_n { get; set; }
        public int Left_n { get; set; }
        public bool Pointer { get; set; }
        public int Clickcount { get; set; }

       ////default constructor
       public RoundButton()
        {
            Caption_n = "RoundButton";
            Height_n = 1;
            Width_n = 1;
            Top_n = 4;
            Left_n = 4;
            Pointer = false;
            Clickcount = 0;
        }

        ////methods
        public void SetPointer_n()
        {
            Pointer = true;
            Top_n -= 1;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"You have set the pointer and {Caption_n} has changed the color and new coordinates are {Top_n}, {Left_n} ");
        }

        public void DoubleClick()
        {
            Clickcount = +2;
            Top_n += 1;
            Console.ResetColor();
            Console.WriteLine($"You've pressed {Caption_n} twice: reset the color and the new coordinates of the button are {Top_n}, {Left_n}");
        }
    }
}
