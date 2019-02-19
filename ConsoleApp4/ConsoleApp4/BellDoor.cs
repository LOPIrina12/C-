using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class BellDoor : IPushable
    {     
        // fields and properties
        public int ClickCount { get; set; }
        public bool Light { get; set; }
        public string Caption { get; set; }

        // default constructor
        public  BellDoor ()
        {
            ClickCount = 0;
            Light = false;
            Caption = "BellDoor";
        }

        //method
        public void Press ()
        {
            ++ClickCount;
            Light = true;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.WriteLine($"You have pressed the {Caption} only once! Nobody listens to you!");
        }
       
        public void DoublePress ()
        {                     
            {
                ClickCount += 2;
                int presstime = 10;       
                for (int i =1; i <= presstime; ++i)
                {
                 Console.Beep();                
                }
                Console.WriteLine($"You have pressed the {Caption} {presstime} times! You are really impatient!");               
            }
        }


    //    public bool Push1 ()
    //    {
    //        ++ClickCount;
    //        Light = true;

    //        Console.Beep();
    //        Console.ForegroundColor = ConsoleColor.Red;
    //        Console.WriteLine($"You've pressed the {Caption} and the light is came on!");
    //        Thread.Sleep(1000);
    //        Console.ResetColor();

    //        return true;
    //    }
        
    //   public bool Push1(int presstime)
    //    {
    //        ++ClickCount;
    //        Console.BackgroundColor = ConsoleColor.Red;
    //        Console.WriteLine ($"{Caption} has been pressed!!!");
    //        for (int i =0; i <= presstime; ++i)
    //        {
    //            Console.Beep();
    //        }
    //        //Thread.Sleep(1000);
    //        //Console.ResetColor();
    //        return true;
    //    }
    }
}
