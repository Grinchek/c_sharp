using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Generic
{
    internal class MyQueue<T>
    {
        public T[] array;
        public MyQueue()
        {

        }
        public MyQueue(T[] array)
        {
            this.array = array;
        }

        public void Dequeue()
        {
            T[] arr = new T[array.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i+1];
            }
            array = arr;
        }
        public void Enqueue(T elem)
        {
            T[] arr = new T[array.Length + 1];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = array[i];
            }
            arr[arr.Length-1] = elem;
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
