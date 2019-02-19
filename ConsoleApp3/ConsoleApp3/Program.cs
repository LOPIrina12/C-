using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр класса Button (create a class instance of the Button)

            Button but = new Button();
            Button butA = new Button(Shape.oval,"AtLast!", 2, 2, 5, 5);
            Button butB = new Button(butA);

            //Console.WriteLine(Button.count);

            Button EQUAL = new Button(Shape.oval,"AtLast!", 2, 2, 5, 5);
            Button EQUAL2 = new Button();
            Console.WriteLine(Button.count);
            //EQUAL = EQUAL2;

            Console.WriteLine("{0}, {1}", EQUAL.Form, EQUAL2.Form);


            int presstime = 5;
            butA.Push();
            butA.Push(presstime);

            //Random rnd = new Random();
            //int width = rnd.Next(2, 4);
            //int height = rnd.Next(2, 4);
            //int left = rnd.Next(1, 10);
            //int top = rnd.Next(1, 10);

            int width = 5;
            int height = 1;
            int top = 10;
            int left = 10;
            butA.ChangeSize(width, height);
            butA.ChangePosition(left, top);
        }
    }
}
