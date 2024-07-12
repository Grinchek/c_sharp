using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Generic
{
    public class MyStack<T>
    {
        public T[] array;
        public MyStack()
        {

        }
        public MyStack(T[] array)
        {
            this.array = array;
        }

        public void Pop()
        {
            T[] arr = new T[array.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i+1];
            }
            array = arr;
        }
        public void Push(T elem)
        {
            T[] arr = new T[array.Length + 1];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = array[i - 1];
            }
            arr[0] = elem;
            array = arr;
        }
        public T Peek()
        {
            return array[0];
        }
        public int Count()
        { return array.Length; }
        public void Display()
        {
            foreach (var item in array)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }

    }
}
