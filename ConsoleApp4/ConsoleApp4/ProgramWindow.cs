using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ProgramWindow : IScalable
    {
        //fields and properties
        public string Caption { get; set; }
        public float Height_n { get; set; }
        public float Width_n { get; set; }
        public int Top_n { get; set; }
        public int Left_n { get; set; }
        public bool Pointer { get; set; }
        
        public int Clickcount { get; set; }

        //default constructor
        public ProgramWindow()
        {
            Caption = "WINDOW";
            Height_n = 10;
            Width_n = 20;
            Top_n = 0;
            Left_n = 0;
            Clickcount = 0;
            Pointer = false;
        }

        //methods
        public void SetPointer_n()
        {
            Pointer = true;
            Console.WriteLine("You've set the pointer.");
        }
            
    
        public void DoubleClick()
        {
            Clickcount += 2;
            Height_n /= 2;
            Width_n /= 2;
            Console.WriteLine($"You've pressed the ProgramWindow twice and new size of the {Caption} is {Height_n} and {Width_n}");
        }
    }
}
