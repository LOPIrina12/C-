using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TASK_2
    {
        //implementation of the method 1
        static int Method1(string str)
        {
            StringBuilder str_n = new StringBuilder(str);
            int count = 1;
            int res = 0;
            int sum = 0;
            int sum1 = 0;
            for (int i = 0; i < str_n.Length; ++i)
            {
                for (int j = i + 1; j < str_n.Length; ++j)
                {
                    if (str_n[i] == str_n[j])
                    {
                        ++count;
                        str_n.Remove(j, 1);
                        str = str_n.ToString();
                        j--;
                    }
                }
                //get the code of the symbol
                //byte code = Encoding.GetEncoding.(1251).GetBytes(str[i]);        
                int code = str_n[i];
                sum = code * count;
                sum1 += sum;
                count = 1;
            }
            res = sum1 % 8;
            //Console.WriteLine(res);
            Console.WriteLine(sum1);
            Console.WriteLine(str_n);
            return res;
        }
    }
}
