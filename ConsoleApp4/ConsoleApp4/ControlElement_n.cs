using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    public enum Shape_n
    {round, square, oval}

    public enum Color
    {gray, blue, green}
    public abstract class ControlElement_n
    {
        //abstract method
        public abstract void Display();

        //fields
        public string caption;
        public Color background;
        public int clickCount = 0;
        public Shape_n form;
        public int top;
        public int left;
        public float height;
        public float width;

        //properties
        public string Caption { get; set; }
        public Color Background { get; set; }
        public int ClickCount { get; set; }
        public Shape_n Form { get; set; } 
        public int Top
        {
            get { return top; }
            set
            {
                if (value >= 0)
                {
                    top = value;
                }
                else
                {
                    Console.WriteLine("Coordinates are not negative");
                }
            }
        }
        public int Left
        {
            get { return left; }
            set
            {
                if (value >= 0)
                {
                    left = value;
                }
                else
                {
                    Console.WriteLine("Coordinates are not negative");
                }
            }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height is not negative");
                }

            }
        }
        public float Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Width is not negative");
                }
            }
        }

        //default constructor
        public ControlElement_n()
        {
            Caption = "Button";
            Background = Color.blue;
            ClickCount = 0;
            Form = Shape_n.square;
            Width = 1;
            Height = 1;
            Top = 0;
            Left = 0;
        }   
 
        //methods
        public virtual bool Push()
        {
            ++ClickCount;
            Console.WriteLine("Button has been pressed");
            return (true);
        }

        public void SetPosition()
        {
            Console.SetCursorPosition(top, left);
            Console.WriteLine($"'{Caption}' has new coordinates: ({top}, {left})");
        }
    }
}
