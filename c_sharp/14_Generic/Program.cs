using _14_Generic;

namespace _c_sharp_
{

    class Program
    {
        public static void MaximumNumber<T>(T[] arr)
        {

            Console.WriteLine($"Maximum number is: {arr.Max()}");
        }
        public static void MinimumNumber<T>(T[] arr)
        {

            Console.WriteLine($"Minimum number is: {arr.Min()}");
        }
        public static T Sum<T>(T[] array) where T : struct
        {
            dynamic sum = default(T);
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
        

        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, };
            MyStack<int> myStack=new MyStack<int>(intArr);
            myStack.Push(10);
            myStack.Display();
            myStack.Pop();
            myStack.Pop();
            myStack.Display();





        }
    }
}