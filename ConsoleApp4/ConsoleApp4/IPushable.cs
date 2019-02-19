
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IPushable 
    {        
        //properties
        int ClickCount { get; set; }

        //method
        void Press();
        void DoublePress();
        //bool DoublePush();        
        //bool Push(int presstime);

    }
}
