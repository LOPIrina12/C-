using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Button : ConsoleApp4.ControlElement_n

    {
        //abstract method
        public override void Display()
        {
            Console.WriteLine($"Caption of the button is - '{Caption}' ");
            Console.WriteLine($"New size of the button is - ({Height},{Width}) ");
            Console.WriteLine($"New coordinates of the button are - ({Top},{Left}) ");
        }

        //field and properties
        public string Hint { get; set; } = "Tested hint";
        public bool ShowHint { get; set; } = false;
        public bool SetPointer { get; set; } = false;

        // method
        public void ChangeSetPointer (float x, float y)
        {
            if (x >= top && x <= (top + height) && y >= left && y <= (left+width))
            {
                SetPointer = true;
                ShowHint = true;
                Console.WriteLine($"Pointer has been set and the hint of the BUTTON is '{Hint}'");
            }
            else
            {
                Console.WriteLine($"Pointer hasn't been set and the hint of the BUTTON isn't shown");
            }
        }
    }
}
