using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public enum Shape
    {
        round, square, oval
    }
    class Button
    {
       
        //class's  fields. Поля в классе принято делать приватными, а чтобы предоставить доступ к полю, то использ. свойство

       public Shape Form { get; set; }

        private string name;
        private string caption;
        private int width;
        private int height;
        private string color;
        public const int sizeHint = 5;
        private int top;//координаты кнопки
        private int left;//координаты кнопки
        private bool isClick;
        public static int count { get; set; } = 0;

        //свойства для этих полей- названия с большой буквы
        public string Name
        {
            get { return this.name; }// чтобы получить значение
            set { this.name = value; }//чтобы присвоить значение
        }


        public string Caption
        {
            get { return this.caption; }// чтобы получить значение
            set { this.caption = value; }//чтобы присвоить значение
        }

       /* public string Shape
        {
            get { return this.shape; }
            set { this.shape = value; }
        }*/

        public string Color
        {
            get { return this.color; }// чтобы получить значение
            set { this.color = value; }//чтобы присвоить значение
        }
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Top
        {
            get { return this.top; }// чтобы получить значение
            set { this.top = value; }//чтобы присвоить значение
        }

        public int Left
        {
            get { return this.left; }// чтобы получить значение
            set { this.left = value; }//чтобы присвоить значение
        }

        public bool IsClick
        {
            get { return this.isClick; }// чтобы получить значение
            set { this.isClick = value; }//чтобы присвоить значение
        }


        //Консруктор по умолчанию
        public Button()
        {
            //инициализация полей
            Name = "button";
            Caption = "BUTTON";
            Form = Shape.square;
            //Shape = "Square";
            color = "gray";
            Width = 5;
            Height = 5;
            Top = 0;
            Left = 0;
            isClick = false;
            ++count;
        }

        //Конструктор с параметрами
        public Button(Shape form, string caption, int width, int height, int top, int left)
        {
            //Инициализация всех полей
            this.Form = form;
            this.Caption = caption;
            this.Width = width;
            this.Height = height;
            this.Left = left;
            this.Top = top;
            isClick = false;
            ++count;

        }

        //Конструктор копирования
        public Button(Button butB)
        {
            //копирует все данные из объекта, переданного параметром "butA" в текущий объект
            this.name = butB.name;
            //this.caption = butA.caption;
            this.width = butB.width;
            this.height = butB.height;
            this.left = butB.left;
            this.top = butB.top;
            this.isClick = butB.isClick;
            ++count;


        }

        //Должно быть три метода

        public void ChangeSize(int width, int height)
        {
            Console.WriteLine($" новый размер кнопки '{caption}' = ({width}, {height})");
        }


        public void Push()
        {
            isClick = true;
            Console.WriteLine(" Кнопка нажата");
        }


        public void Push(int presstime)
        {
            isClick = true;
            Console.WriteLine(" Кнопка зажата на {0} милисекунд ", presstime);
            System.Threading.Thread.Sleep(presstime);
        }

        public void ChangePosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"Новые координаты кнопки '{caption}' = ({top}, {left})");
        }


        public static int QuantityVariables()
        {
            Console.WriteLine("Ваше количество экземпляров класса = " + count);

            return (count);
        }

        //финализатор
        ~Button()
        {

        }

    }

   
}

