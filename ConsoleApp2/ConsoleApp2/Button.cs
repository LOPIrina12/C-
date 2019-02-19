using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Button
    {
        //class's  fields. Поля в классе принято делать приватными, а чтобы предоставить доступ к полю, то использ. свойство
        private string name;
        private string caption;
        private int width;
        private int height;
        public const string color = "blue";
        private int top;//координаты кнопки
        private int left;//координаты кнопки
        private bool isClick;
        public static int count;

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

        public static int Count
        {
            get; set;
        }
        //Статический конструктор
        static Button()
        {
            count += 1;
        }

        //Консруктор по умолчанию
        public Button()
        {
            //инициализация полей
            Name = "button";
            Width = 5;
            Height = 5;
            Caption = "button1";
            Top = 0;
            Left = 0;
            isClick = false;

        }

        //Конструктор с параметрами
        public Button(string name, int width, int height, int top, int left)
        {
            //Инициализация всех полей
            this.name = name;
            this.width = width;
            this.height = height;
            this.left = left;
            this.top = top;
            isClick = false;

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
        }

        //Должно быть три метода
        public bool SetCaption(string cap)
        {
            Caption = cap;
            return true;
        }

        public string GetCaption()
        {
            return Caption;
        }

        public void ChangeSize(int width, int height)
        {
            Console.WriteLine($" новый размер кнопки '{name}' = ({width}, {height})");
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
            Console.WriteLine($"Новые координаты кнопки '{name}' = ({top}, {left})");
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
