using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IScalable 
    {
        //properties
        bool  Pointer { get; set; }
        int Clickcount { get; set; }
        float Height_n { get; set; }
        float Width_n { get; set; }
        int Top_n { get; set; }
        int Left_n { get; set; }

        //methods
        void SetPointer_n();
        void DoubleClick();
    }
}
