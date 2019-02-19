using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
           

            // You use IPushable for BellDoor and TextBox
            BellDoor bell = new BellDoor();
            TextBox text = new TextBox();

            //bell.Press();
            //bell.DoublePress();

            human.PushOn(bell);
            //SetColor(bell);
           
            //You use IScalable for ProgramWindow and RoundButton
            ProgramWindow window = new ProgramWindow ();
            //window.DoubleClick();

            RoundButton round_but = new RoundButton();
           // round_but.SetPointer_n();
            //round_but.DoubleClick();

            //create the array or List
            List<IPushable> pushables = new List<IPushable>();
            pushables.Add(bell);
            pushables.Add(text);


           // ControlElement_n [] elements = {new BellDoor, new TextBox };


            //CheckBox box = new CheckBox { Caption = "CheckBox", Height = 0.5f, Width = 0.5f, Top = 10, Left = 10, };//            
            //box.SetPosition();
            //box.Display();
            ////box.Push();

            //RoundButton roundButton = new RoundButton { Caption = "ROUND_BUTTON", Left = 27, Top = 27, Form = Shape_n.round };
            //roundButton.SetPosition();
            //roundButton.Display();

            //int count = 0;
            //do
            //{
            //    box.Push();
            //    roundButton.SetAvaliable(box.Checked);
            //    if (roundButton.Available == true)
            //    {
            //        roundButton.Push();
            //    }
            //    else
            //    {
            //        Console.WriteLine("roundButton hasn't been pushed as TextBox hasn't been chosen.");
            //    }

            //    ++count;
            //} while (count < 3); //check for truth

            //Button button = new Button { Caption = "BUTTON", Width = 3, Top = 16, Left = 16 };
            //button.SetPosition();
            //button.Display();
            //float x = 16.5f;
            //float y = 18;
            //button.ChangeSetPointer(x, y);

            //BitBtn bitBtn = new BitBtn { Caption = "BITBTN", width = 3, height = 2, Top = 22, Left = 22 };
            //bitBtn.SetPosition();
            //bitBtn.Display();
            //bitBtn.LoadPicture();

            //TextBox text = new TextBox { Caption = "Searching", Width = 5, Background = Color.gray, Top = 2, Left = 2 };//Top = 2, Left = 2
            //text.SetPosition();
            //text.Display();
            //text.Push();
            //text.EnterText();
            //text.CutText();
        }


        static void SetColor (IPushable pushable)
        {
            pushable.Press();

        }
    }


    class Human
    {

        public void PushOn(IPushable pushable)
        {
            Console.WriteLine("Человек нажимает на это!");
            pushable.Press();
            Console.WriteLine("Сюда нажимали {0} раз!", pushable.ClickCount);
        }
    }
}
