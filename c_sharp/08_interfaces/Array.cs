using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interfaces
{
    internal class My_Array : IOutput, ISort, IMath
    {
        Random random=new Random();
        int[] array;
        public My_Array(int size)
        {
            array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
        }
        public float Avg()
        {
            return (float)array.Average();
        }

        public int Max()
        {
            return array.Max();
        }

        public int Min()
        {
            return array.Min();
        }

        public void My_Show()
        {
            foreach (var elem in array) 
            {
                Console.Write($"[{elem}] ");
            }
            Console.WriteLine();
        }

        public void My_Show(string info)
        {
            Console.WriteLine(info);
            foreach (var elem in array)
            {
                Console.Write($"[{elem}] ");
            }
            Console.WriteLine();
        }

        public bool Search(int valueToSearch)
        {
            bool result = false;
            foreach(int value in array)
            {
                if (value == valueToSearch)
                {
                    result= true;
                }
                else
                {
                    result= false;
                }
            }
            return result;
        }

        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

    }
}
