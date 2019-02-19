using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Set <T>
    {
        //property
        public int Count
        {
            get
            {
                return SList.Count;//
            }
        }

        List<T> SList { get; set; }

        //default constructor
        public Set ()
        {
            SList = new List<T>();

        }

        //constructor with params
        public Set (T [] integers)
        {
            SList = new List<T>();
            //a loop to add integers into the list "s"
            for (int i = 0; i < integers.Length; ++i)
            {
                Add_(integers[i]);
            }
        
           
        }

        public void ShowVal()
        {
            for (int i =0; i < SList.Count; ++i)          
            {
                Console.Write("[" + SList[i] + "], ");
            }
            Console.WriteLine();
        }
        // without repeated elements
        public void Add_(T newVal)
        {

            for (int i = 0; i < SList.Count; ++i)
            {
                if (SList[i].Equals(newVal))
                //if (newVal == SList[i])
                {
                    return;
                }
            }
            SList.Add(newVal);
        }

        

        public void Remove_ (T elm)
        {
            SList.Remove(elm);                       
        }

        public Set<T>  Union (Set<T> s1)
        {
            //create a new class instance and add elements from 
            Set <T> s21 = new Set<T>();    
           

            //So the method UNION was called by s1 therefore SList was initialized by its array 
            for (int i = 0; i < SList.Count; ++i)
            {
                s21.Add_(SList[i]);
            }
   
            for (int i = 0; i < s1.SList.Count; ++i)
            {
                s21.Add_(s1.SList[i]);
            }
            return s21;
        }

        public Set<T> Intersect(Set<T> s1)
        {
            Set<T> s31 = new Set<T>();

            for (int i = 0; i < this.SList.Count; ++i)
            {
                for (int j = 0; j < s1.SList.Count; ++j)
                {
                    if (SList[i].Equals(SList[j]))
                    //if (SList[i] == s1.SList[j])
                    {
                        s31.SList.Add(this.SList[i]);
                    }
                }
            }
            return s31;
        }

        //set_to_remove = s2

        public Set<T> Differnce(Set<T> set_to_remove)
        {
            //
            Set<T> s51 = new Set<T>(SList.ToArray());//s51 = s1

            for (int i = 0; i < set_to_remove.Count; ++i)
            {
                for (int j = 0; j < s51.SList.Count; ++j)
                {
                    if (s51.SList[j].Equals(set_to_remove.SList[i]))
                    //if (s51.SList[j] == set_to_remove.SList[i])
                    {
                        s51.Remove_(set_to_remove.SList[i]);
                        break;
                    }
                }
                //Console.WriteLine(this.SList[i]);
            }
            return s51;
        }

        public Set<T> SymmetricDifference(Set<T> s2)
        {
            Set<T> s71 = new Set<T>(SList.ToArray());// set = s1 created to remove extra elements
            Set<T> s81 = new Set<T>(s2.SList.ToArray());// set = s2 created to remove extra elements

            for (int i = 0; i < s81.Count; ++i)
            {
                for (int j = 0; j < s71.Count; ++j)
                {
                    if (s81.SList[i].Equals(s71.SList[j]))
                    {
                        s71.Remove_(s71.SList[j]);
                        s81.Remove_(s81.SList[i]);
                        --i;
                        break;
                    }
                }
            }

            for (int i = 0; i < s81.SList.Count; ++i)
            {
                s71.Add_(s81.SList[i]);
            }

            return s71;

        }

        //paragraph 7

        public bool IsSubsetOf(Set<T> s9)
        {
            //a variable in order to count subset's elements that are found in a set
            int count = 0;

            for (int i = 0; i < SList.Count; ++i)
            {
                for (int j = 0; j < s9.SList.Count; ++j)
                {
                    if (SList[i].Equals(s9.SList[j]))
                    {
                        ++count;
                        //Console.WriteLine("A element of the set belongs to a set");
                    }
                }
            }

            if (count == SList.Count)//if it works it means that a set includes a subset
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
        //PART 2
        //RARAGRAPH 2.1
        //Operator overloading +
        //we need 2 object as arguments
        //return an object Set

        //Method
        //
        public static Set<T> operator +(Set<T> first, Set<T> second)
        {
            Set<T> set_new = new Set<T>();
            set_new = first.Union(second);
            return set_new;
        }

        //Operator overloading *
        //we need 2 object as arguments
        //return an object Set

        public static Set<T> operator *(Set<T> first, Set<T> second)
        {
            Set<T> set_intersect = new Set<T>();
            set_intersect = first.Intersect(second);
            return set_intersect;
        }

        //Operator overloading -
        //we need 2 object as arguments
        //return an object Set

        public static Set<T> operator -(Set<T> first, Set<T> second)
        {
            Set<T> set_differnce = new Set<T>();
            set_differnce = first.Differnce(second);
            return set_differnce;
        }

        //Operator overloading %
        public static Set<T> operator %(Set<T> first, Set<T> second)
        {
            Set<T> set_sym = new Set<T>();
            set_sym = first.SymmetricDifference(second);
            return set_sym;
        }

        //Operator overloading <>
        public static bool operator >(Set<T> first, Set<T> second)
        {

            return first.IsSubsetOf(second);

        }

        public static bool operator <(Set<T> first, Set<T> second)
        {

            return first.IsSubsetOf(second);

        }
      
       

    }

    // PARAGRAPH 5.2


}
