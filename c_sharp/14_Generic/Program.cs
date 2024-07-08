namespace _c_sharp_
{

    class Program
    {
        public static void MaximumNumber<T>(T a,T b, T c) 
        {
            T max;
            if (a > b || a > c)
            {
                max = a;
            }
            Console.WriteLine($"Maximum number is: {max}");
        }
        static void Main(string[] args)
        {

        }
    }
}