using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class BitBtn : ConsoleApp4.Button
    {
        //abstract method
        public override void Display()
        {
            Console.WriteLine($"Caption of the button is - '{Caption}' ");
            Console.WriteLine($"New size of the button is - ({Height},{Width}) ");
        }

        //field and property
        public bool Picture { get; set; } = false;
        
        //method
        public bool LoadPicture ()
        {
            Picture = true;

            using (System.IO.FileStream fstream = File.OpenRead(@"F:\Кнопка.png"))

            {
                Console.WriteLine("Picture is successfully downloaded");
            }

            return (Picture);

           
        }
       
    }
}
