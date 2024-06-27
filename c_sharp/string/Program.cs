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

            //string str = "You have power over your mind - not outside events";
            //string[] arr = str.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
            //string str2 = string.Empty;
            //foreach (string c in arr)
            //{
            //    str2 += c;
            //}
            //str = str2;
            //Console.WriteLine(str);
            //int counter = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (char.IsUpper(str[i]))
            //    {
            //        counter++;
            //    }
            //}
            //double persentage = (str.Length/100.0)*counter;
            //Math.Round(persentage,2);
            //Console.WriteLine($"There are {persentage} % of capital letter.");
            // #4

            //string[] array = { "Hello", "it", "is","beautiful","course", "of","powerfull", "programing", "language", "c-sharp" };
            //int user_length = 9;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = array[i].Length-1; j >= array[i].Length-3 ; j--)
            //    {
            //        if (array[i].Length == user_length)
            //        {
            //            char[] carr=array[i].ToCharArray();
            //            for(int k= carr.Length-1; k >= carr.Length - 3; k--)
            //            {
            //                carr[k] = '$';
            //            }
            //            array[i] = string.Join("", carr);

            //        }
            //    }
            //}
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            // #5

            //string[] array = { "Hello", "it", "is", "beautiful", "course", "of", "powerfull", "programing", "language", "c-sharp" };
            //int user_number = 2;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i == user_number-1)
            //    {
            //        char[] carr = array[i].ToCharArray();
            //        Console.WriteLine(carr[0]);
            //    }
            //}

            // #6
            //string str = "  You  have      power    over   your  mind  -  not   outside  events ";
            //Console.WriteLine(str);
            //string[] strarr = str.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
            //StringBuilder sb = new StringBuilder();
            //for (int i=0;i< strarr.Length-1;i++)
            //{
            //    sb.Append($"{strarr[i]}*");
            //}
            //sb.Append(strarr[strarr.Length-1]);
            //Console.WriteLine(sb);

            // #7
            StringBuilder sb = new StringBuilder();
            bool ex = false;
            while (!ex)
            {
                string str=Console.ReadLine();
                if (str[str.Length - 1] != '.')
                {
                    sb.Append($"{str}, ");
                }
                else
                {
                    sb.Append($"{str}");
                    ex = true;
                }
            }
            Console.WriteLine( sb.ToString() );



        }
    }
}