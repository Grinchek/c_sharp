using _07_overloading_operator;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace _c_sharp_
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Square s = new Square(10);
            Console.WriteLine(s);
            s++;
            Console.WriteLine(s);
            Square s2 = new Square(10);
            if(s2 != s) { Console.WriteLine("Objects are not equal"); }
            else { Console.WriteLine("Objects are equal"); }
            s2++;
            if (s2 != s) { Console.WriteLine("Objects are not equal"); }
            else { Console.WriteLine("Objects are equal"); }

            Rectangle r = new Rectangle(5,10) ;
            Console.WriteLine(r);
            r++;
            Console.WriteLine(r);
            Rectangle r2 = new Rectangle(5,10);
            if (r != r2) { Console.WriteLine("Objects are not equal"); }
            else { Console.WriteLine("Objects are equal"); }
            r2++;
            if (r2 != r) { Console.WriteLine("Objects are not equal"); }
            else { Console.WriteLine("Objects are equal"); }
            Console.WriteLine("=============================");
            r--;
            s = r;
            Console.WriteLine(s);
            s2--;
            r2 = s2;
            Console.WriteLine(r2);






        }

    }
}