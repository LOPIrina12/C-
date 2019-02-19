using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //PARAGRAPH 1-5

            //declare the array of numbers
            int[] array = new int[] {3,4,7,2,-3,4,4,87,45};
            int newVal =  5;
            Set <int> s = new Set<int>(array);
            //s.ShowVal();
            //s.Add(newVal);
            //int elm = 4;
            //s.Remove_(elm);
            //s.ShowVal();
            //declare 2 sets


            //PARAGRAPH 6

            Set<int> s1 = new Set <int>(new int[] {3,4,7,2,-3});
            Set<int> s2  = new Set<int> (new int[] {6,3,1,-3,8,13,2 });

            Set<string> st = new Set<string> (new string[] { "A", "B"});
            Set<string> st1 = new Set<string> (new string[] { "C", "D" });

            CheckBox box1 = new CheckBox("new cap");
            //box1.Caption = "new cap";
            CheckBox box2 = new CheckBox("box2");

            CheckBox box3 = new CheckBox("box3");
            CheckBox box4 = new CheckBox("box4");

            Set<ControlElement_n> but = new Set<ControlElement_n>(new CheckBox[] {box1, box2, box3 });
            Set<ControlElement_n> but1 = new Set<ControlElement_n>(new CheckBox[] { box3, box4, box4 });

            //Union s1 and s2
            //Set<int> s3 = s1.Union(s2);
            //Set<string> stt = st.Union(st1);
            Set<ControlElement_n> BUT = but.Union(but1);
            //s3.ShowVal();
            //stt.ShowVal();
            but.ShowVal();
            but1.ShowVal();


            BUT.ShowVal();

            //Intersect s1 and s2
            //Set<int> s4 = s1.Intersect(s2);
            //s4.ShowVal();

            //Difference s1 and s2
            // this равно экземпляру класса вызывается неявно при создании 

            //Set<int> s5 = s1.Differnce(s2);
            //s5.ShowVal();

            //Set<int> s6 = s1.SymmetricDifference(s2);
            //s6.ShowVal();


            //PARAGRAPH 7
            //check subset

            Set<int> s7 = new Set<int>(new int[] { 1, 2, 6 });
            Set<int> s8 = new Set<int>(new int[] { 3, 5, 8, 4 });
            Set<int> s9 = new Set<int>(new int[] { 3, 4, 5, 6, 7, 8 });

            //s7.IsSubsetOf(s9);
            //s8.IsSubsetOf(s9);


            //PART 2
            //PARAGRAPH 2.1

            // +
            ////Set<int> set_plus = new Set<int>();
            ////set_plus = s1 + s2;
            //////set_plus.ShowVal();

            ////// *
            ////Set<int> set_inter = new Set<int>();
            ////set_inter = s1 * s2;
            //////set_inter.ShowVal();

            ////// -
            ////Set<int> set_dif = new Set<int>();
            ////set_dif = s1 - s2;
            //////set_dif.ShowVal();

            ////// %
            ////Set<int> set_symm = new Set<int>();
            ////set_symm = s1 % s2;
            //////set_symm.ShowVal();

            //////>

            ////bool fls = s9 > s7;

            //////<
            ////bool tr = s8 < s9;





            //studying array
            //int sz = array.Length;
            //             for (int i = 0; i < sz; ++i)
            //             {
            //                 for (int j = i + 1; j < sz; ++j)
            //                 {
            //                     if (array[i] == array[j])
            //                     {
            //                         for (int k = j; k < sz - 1; ++k)
            //                         {
            //                             array[k] = array[k + 1];
            //                         }
            //                         --sz;
            //                         --j;
            //                     }
            //                 }
            //             }

            //             for (int i = 0; i < sz; ++i)
            //             {
            //                 Console.Write(" " + array[i] + " ");
            //             }

            //studying method
            //aa(array);

        }





        //static void aa (int [] array)
        //{

        //    List<int> ss = new List<int>();


        //    for (int k = 0; k < array.Length; ++k)
        //    {
        //        foreach (int j in ss)
        //        {
        //            ss.Add(array[k]);
        //        }

        //    }

        //    foreach (int i in ss)
        //        {
        //            ss.Add(i);


        //        }

        //        foreach (int i in ss)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}
    }
}
