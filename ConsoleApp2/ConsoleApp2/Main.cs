using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    

    class Program
    {
        
        static void Main()
        {
            //method 2
            //создаем экземпляр класса Button (create a class instance of the Button)

            Button but = new Button();
            Button butA = new Button("buttonA", 1, 1, 5,5);
            Button butB = new Button(butA);
            RotateButton rb = new RotateButton();
            rb.Caption = "kjhkjh";
            rb.SetCaption("jkhgkhg");

            int presstime = 5;
            butA.Push();
            butA.Push(presstime);

            Random rnd = new Random();
            int width = rnd.Next(2, 4);
            int height = rnd.Next(2, 4);
            int left = rnd.Next(1, 10);
            int top = rnd.Next(1, 10);
            butA.ChangeSize(width, height);
            butA.ChangePosition(left, top);


            //Button.QuantityVariables();
            /*string str = "lopatina";
            //call method1, transfer "str", get "result" 
            int res1 = Method1(str);
            Console.WriteLine("Your result is = " + res1);*/
        }

        
    }
  
}

