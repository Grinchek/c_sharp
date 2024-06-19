using System.Text;

namespace _c_sharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            //string str1 = "Hello";
            //string str2 = " world";
            //string str3 =str1.Insert(5,str2);
            //Console.WriteLine(str3);

            // #2

            //string str = "Level";
            //string strTest=str.ToLower();
            //if (strTest.SequenceEqual(strTest.Reverse()))
            //{
            //    Console.WriteLine("The word is palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("The word is not palindrome");
            //}

            // #3

            string str = "You have power over your mind - not outside events";
            string[] arr = str.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
            string str2 = string.Empty;
            foreach (string c in arr)
            {
                str2 += c;
            }
            str = str2;
            Console.WriteLine(str);
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    counter++;
                }
            }
            double persentage = (str.Length/100.0)*counter;
            Math.Round(persentage,2);
            Console.WriteLine($"There are {persentage} % of capital letter.");


        }
    }
}