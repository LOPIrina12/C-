using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1

{
    class Program
    {
       
        static void Main()
        {
            //TASK 10 (fix the mistake from task 9)
            //Method 11
            //declare an array and initialize it
            int[] array = new int[] { 1, 3, 4, 6, 6 };

            //Get the random number and fill the array

            Random rnd = new Random();

            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; ++i)
            {
                //Random rnd = new Random();
                int value = rnd.Next(1, 10);
                arr[i] = value;
            }

            Console.WriteLine("The random arr is: ");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr.GetValue(i));
            }
            Console.WriteLine(" ");
            //call of the method11 and transfer arguments to method10 to implementation it

            Array final = Method11(array, arr);
            //write the array on the console
            Console.WriteLine("The final array is: ");
            for (int i = 0; i < final.Length; ++i)
            {
                Console.Write(final.GetValue(i));
            }
            Console.WriteLine(" ");

            //Task 9 (try + catch + finally)
            //declare an array and initialize it
            /*    int[] array = new int[] { 1, 3, 4, 6, 6 };

                //Get the random number and fill the array

                //Random rnd = new Random();

                int[] arr = new int[3];
                for (int i = 0; i < arr.Length; ++i)
                {
                    Random rnd = new Random();
                    int value = rnd.Next(1, 10);
                    arr[i] = value;
                }

                Console.WriteLine("The arr is: ");
                for (int i = 0; i < arr.Length; ++i)
                {
                    Console.Write(arr.GetValue(i));
                }
                Console.WriteLine(" ");
                //call of the method10 and transfer arguments to method10 to implementation it

                Array final = Method10(array, arr);
                //write the array on the console
                Console.WriteLine("The final array is: ");
                for (int i = 0; i < final.Length; ++i)
                {
                    Console.Write(final.GetValue(i));
                }
                Console.WriteLine(" ");
                */

            //TASK 8.2 (tuple)
            //declare an array, variable and initialize it
            /*   
                       var tuple = Method9(new int[] { 10, 15, 5, -4, -1, 4, 17, 25 });

                       //write the result

                       Console.WriteLine(" Min = {0}\n Max = {1}\n Avr = {2}\n  ", tuple.Item1, tuple.Item2, tuple.Item3);
           */
            //TASK 8.1 (out)
            /*
                        //declare an array and initialize it
                        int[] arr = new int[] { 10, 15, 5, -4, -1, 4, 17, 25 };
                        //declare variables
                        int min = 0;
                        int max = 0;
                        double avr = 0;

                        //call of the method8 and transfer arguments to method8 to implementation it

                        Method8(arr, out min, out max, out avr);

                        //write the result
                        Console.Write($"Min value ={min}\n");
                        Console.Write($"Max value ={max}\n");
                        Console.Write($"Avr value = {avr}\n");
            */
            //TASK №7 (params + return)
            /*
                        //declare an array and initialize it
                        int[] array = new int[] { 1, 3, 4, 6, 6 };
                        //call of the method7 and transfer arguments to method7 to implementation it
                        Array final = Method7(array, 3, 6);
                        //write the array on the console
                        Console.WriteLine("The final array is: ");
                        for (int i = 0; i < final.Length; ++i)
                        {
                            Console.Write(final.GetValue(i));
                        }
            */
            //Method1();// TASK 4 (write С#)
            //Method2();// TASK 6 (sum 2 arrays)
            //Method3();// TASK 3 (factorial)
            //Method4();// TASK 5 (keyboard)
            //Method5();// TASK 2 (stone, sсissors, paper)
            //Method6();// TASK 1 (I'll do my best)


        }

        //implementation of the method 11 /task10/
        private static Array Method11(int[] array, int[] arr)
        {
            //verifying "arr" and change repeated components to "-1"  
            
            for (int i =0; i < arr.Length - 1; ++i)
            {
                for ( int n = i +1; n < arr.Length; ++n)
                {
                    if (arr[i] == arr[n])
                    {
                        arr[i] = -1;
                    }
                }
            }

            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr.GetValue(i));
            }
            Console.WriteLine(" ");       

            //circle to compare components 
            int count = 0; //the component's number to delete
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < array.Length; ++j)
                {
                    if (arr[i] == array[j] && arr[i] !=-1)
                    {
                        ++count;
                    }
                }
            }

            Console.WriteLine("The number of component to delete = " + count);
            // the size of a new array
            int sz = 0;
            sz = array.Length - count;
            Console.WriteLine("The new size of an array = " + sz);

            int[] final = new int[sz];

            //cull(перебор) the array

            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < array.Length; ++j)
                {
                    //compare array's components to "arr" that was received
                    if (arr[i] == array[j])
                    {
                        array[j] = -100;
                    }
                }
            }
       
            // delete "-100" 
            int k = 0;
            
                for (int j = 0; j < array.Length; ++j)
                {
                    //compare array's elements to -100
                    if (array[j] != -100)
                    {
                        final[k] = array[j];
                        ++k;
                    }
                }              
            return final;
        }

        //implementation of the method 10 /task9/
        private static Array Method10(int[] array, int[] arr)
        {      
            //circle to compare components 
            int count = 0; //the component's number to delete
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < array.Length; ++j)
                {
                    if (arr[i] == array[j])
                    {
                        ++count;
                    }
                }
            }

            Console.WriteLine("The number of component to delete = " + count);
            // the size of a new array
            int sz = 0;
            sz = array.Length - count;
            Console.WriteLine("The new size of an array = " + sz);

            int[] final = new int[sz];

            //cull(перебор) the array and control of the two arguments that were received

            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < array.Length; ++j)
                {
                    //compare array's components to arguments that were received
                    if (arr[i] == array[j])
                    {
                        array[j] = -100;
                    }
                }
            }
           
            // delete -100 
            int k = 0;
            try
            {
                for (int j = 0; j < array.Length; ++j)
                {
                    //compare array's elements to -100
                    if (array[j] != -100)
                    {
                        final[k] = array[j];
                        ++k;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Your array is overloaded " + ex.Message);
            }
            finally
            {
                Console.WriteLine(" ");
                Console.WriteLine("Block finally");
            }
            return final;
        }

        //implementation of the method 9 /task8.2/
        private static Tuple<int, int, double> Method9(int []arr_n)
        {
            //var result = (min_n: 0, max_n: 0, avr_n: 0);

            int count = 0;

            for (int i = 0; i < arr_n.Length; ++i)
            {
                if (arr_n[i] < 0)
                {
                    ++count;
                }
            }
            //find the size of the array
            int size = arr_n.Length - count;

            //declare a new array and fill it
            int[] arr_pos_n = new int[size];
            int k = 0;
            for (int i = 0; i < arr_n.Length; ++i)
            {
                if (arr_n[i] > 0)
                {
                    arr_pos_n[k] = arr_n[i];
                    ++k;
                }
            }

            Array.Sort(arr_pos_n);

            for (int i = 0; i < arr_pos_n.Length; ++i)
            {
                Console.Write(" " + arr_pos_n[i] + " ");
            }

            Console.WriteLine(" ");
            int min_n = arr_pos_n.Min();
            int max_n = arr_pos_n.Max();
            double avr_n = arr_pos_n.Average();

            return Tuple.Create<int, int, double>(min_n, max_n,avr_n);
        
        }
         
        //implementation of the method 8.1
        private static void Method8 (int[] arr, out int min1, out int max1, out double avr1)
        {
            int count = 0;
           
            for(int i=0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    ++count;
                }
            }
            //find the size of the array
            int size = arr.Length - count;

            //declare a new array and fill it
            int[] arr_pos = new int[size];
            int k = 0;
            for (int i=0; i < arr.Length; ++i)
            {
                if (arr[i] > 0)
                {
                    arr_pos[k] = arr[i];
                    ++k;
                }
            }

            Array.Sort(arr_pos);

            for (int i = 0; i < arr_pos.Length; ++i)
            {
                Console.Write(" " + arr_pos[i] + " ");
            }

            Console.WriteLine(" ");
            min1 = arr_pos.Min();
            max1 = arr_pos.Max();
            avr1 = arr_pos.Average();
         }
        
        //implementation of the method7
        private static Array Method7(int[] array, params int[] integers)
        {
            //circle to define the size of the array
            int count = 0;
            for (int i = 0; i < integers.Length; ++i)
            {
                for (int j = 0; j < array.Length; ++j)
                {
                    if (integers[i] == array[j])
                    {
                        ++count;
                    }
                }
            }
            
            // Console.Write("The number of elements to delete" + count);
            // the size of a new array
            int sz = 0;
            sz = array.Length - count;
            //Console.Write("The new size of an array = " + sz);

            int[] final = new int[sz];
 
            //cull(перебор) the array and control of the two arguments that were received

            for (int i = 0; i < integers.Length; ++i)
            {
                    for (int j = 0; j < array.Length; ++j)
                    {
                        //compare array's elements to arguments that were received
                        if (integers[i] == array[j])
                        {
                        array[j] = -100;                            
                        }
                    }
            }
            
            // delete -100 
            int k = 0;
            for (int j = 0; j < array.Length; ++j)
            {
                //compare array's elements to -100
                if (array[j] != - 100)
                {
                    final[k] = array[j];
                    ++k;
                }
            }
            
            return final;
        }

        static void Method1()
        {
            //TASK 4

            int count = 0;
            int left = 0;//variable for location
            int top = 0;// variable for location-координаты

            while (count < 30)
            {
                Random rnd = new Random();
                //random for  top and left

                left = rnd.Next(0, Console.WindowWidth);
                top = rnd.Next(0, Console.WindowHeight);

                Console.SetCursorPosition(left, top);
  
                Console.Write("C#");

                //A pause to stop console c#

                System.Threading.Thread.Sleep(250);

                //Clean a console
                Console.Clear();
                ++count;

            }
        }
        static void Method2()
        {
            //declare an array and initialize
            int[] mas = new[] { 15, 25, 1, 2, 100, 0, 35, 8, 10, 14 };
            int[] mas1 = new int[10];
            int[] mas2 = new int[10];

            // write an array on the console
            Console.WriteLine("mas");
            for (int i = 0; i < mas.Length; ++i)
                Console.Write(" " + mas[i] + " ");
                Console.WriteLine(" ");

            Array.Copy(mas, mas1, 10);
        
            //sorting by increasing
            Array.Sort(mas1);
            //sorting by descending
            Array.Reverse(mas1);

            Console.WriteLine("mas1_reverse");

            for (int i = 0; i < mas1.Length; ++i)
                Console.Write(" " + mas1[i] + " ");
            Console.WriteLine(" ");
                
            // sum 2 arrays
            for( int i = 0; i < 10; ++i )
            {
                mas2[i] = mas[i] + mas1[i];
            }

            // write the arrays on the console
            Console.WriteLine("mas2");
            for (int i = 0; i < mas2.Length; ++i)
            Console.Write(" " + mas2[i] + " ");
            Console.Write(" ");

        }
        static void Method3()
        {

            //TASK 3,1

            double item =1;// item - слагаемое
             double y = 1;
             double result = 1;
             int i = 1;

             while (item > 0.0000001)
             {
                 //вычисляем факториал
                 y = y * i;
                 ++i;
                 item = 1 / y;
                 result = result + item;
             }
             Console.Write("Результат решения суммы ряда = ");
             Console.WriteLine(result);

            //TASK 3,2

            double n=0; //счётчик//counter
            double result_item = 0;//результат очередного слагаемого//the result of current item
            double sum = 0; //сумма ряда//sum os series
            double result_ex = 0;
            double rslt_item_abs = 1;

            while (rslt_item_abs > 0.0000001)
            {
                result_item = (Math.Pow(-1, n)) / ((2 * n) + 1);
                sum = sum + result_item;
                ++n;
                rslt_item_abs=Math.Abs(result_item);
            }

             result_ex = 4 * sum;
            Console.Write("Результат решения суммы ряда = ");
            Console.WriteLine(result_ex);
        }
        static void Method4()
        {
            int atmp = 0;

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Введите символ, который видите");
                Random rnd = new Random();
                //Получить случайное число ( в диапазоне от 65 до 87)
                int value = rnd.Next(65, 87);

                //convert int to string
                //string symbol_C = Convert.ToString(value);

                char symbol_C = (char)value;
                Console.WriteLine(symbol_C);

                //User enter the symbol_U
                string symbol_U = Console.ReadLine();

                //compare
                if (symbol_C == symbol_U.ElementAt(0))
                {
                    if (i == 4)
                    {
                        Console.WriteLine("Вы молодец!");
                    }
                }
                else
                {
                    i = 0;
                    ++atmp;
                    if (atmp == 3)
                    {
                        Console.WriteLine("Не в этот раз!");
                        //i = 5;
                        break;
                        
                    }
                }
            }
        }
        static void Method5()
        {
            //ЗАДАНИЕ 2
            string str1 = "ножницы";
            string str2 = "камень";
            string str3 = "бумага";
            string str4 = " ";
            Console.WriteLine("Введите любое значение");

            string str = Console.ReadLine();
            // проверка stringa  на камень, ножницы, бумага.
            if (str != str1 && str !=str2 && str !=str3)
            {
                Console.WriteLine("Попробуйте ещё раз!");
            }
            else
            {
                Random rnd = new Random();
                //Получить случайное число ( в диапазоне от 1 до 3)
                int value = rnd.Next(1, 3);
                Console.WriteLine(value);

                switch (value)
                {
                    case (1):
                        str4 = str1;
                        break;
                    case (2):
                        str4 = str2;
                        break;
                    case (3):
                        str4 = str3;
                        break;
                    default: Console.WriteLine("Default case"); break;

                }
                Console.WriteLine(str4);
                
                //сравнение строки пользователя со строкой ПК
                if (str == str4)
                {
                    Console.WriteLine("Ничья");
                }

                if (str==str1 && str4==str3 || str == str3 && str4 == str2 || str == str2 && str4 == str1)
                {
                    Console.WriteLine("Победа пользователя");
                }
                else
                {
                    Console.WriteLine("Победа компьютера");
                }
                
            }
        }
        static void Method6()
        {
            //ЗАДАНИЕ №1

            string str = "Я буду усердно делать все задания по C# и заниматься дома";
            string str1 = "За это ты получишь печеньку";
            Console.WriteLine("Введите строку на консоль");
      
            string str2 = Console.ReadLine();

            if (String.Compare(str, str2, true) == 0)
                Console.WriteLine(str1);
            else
                Console.WriteLine("Попробуйте ещё раз");
        }

    }
}


      
       // private static Random random = new Random();

                      
           
      
    


