using _08_interfaces;

namespace _c_sharp_
{
    class Program
    {
        public static void Main(string[] args)
        {
            My_Array array = new My_Array(5);
            array.My_Show();
            Console.WriteLine("====================");
            array.SortAsc();
            array.My_Show();
            Console.WriteLine("====================");
            array.SortDesc();
            array.My_Show("My message");
            array.SortByParam(true);
            Console.WriteLine("====================");
            array.My_Show();
            Console.WriteLine("====================");
            Console.WriteLine(array.Search(22));

        }
    }
}