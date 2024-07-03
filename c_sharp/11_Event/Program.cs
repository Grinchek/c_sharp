using _c_sharp_;
using System.Data.Common;

namespace _c_sharp_
{
    static class MyExtansion
    {
        public static void IsPalindrome(this string data)
        {
            string str = Console.ReadLine();
            string strTest = str?.ToLower();
            if (strTest.SequenceEqual(strTest.Reverse()))
            {
                Console.WriteLine("The word is palindrome.");
            }
            else
            {
                Console.WriteLine("The word is not palindrome");
            }
        }
        public static string Enigma(this string data)
        {
            string shrift="";
            for(int i = 0; i < data.Length; i++)
            {
                shrift+=Convert.ToChar(data[i]+3); 
            }
            return shrift; 
        }
        public static string TurringMethod(this string data,string key)
        {
            if (key == "swordfish")
            {
                string descrypt = "";
                for (int i = 0; i < data.Length; i++)
                {
                    descrypt += Convert.ToChar(data[i] - 3);
                }
                return descrypt;
            }
            return "wrong key";
        
        }
        
            }

            


        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string data = "Someone or something that is mysterious or puzzling";
            string message=data.Enigma();
        Console.WriteLine(message.TurringMethod("swordfish"));
        Console.WriteLine("__________________________");
        Console.WriteLine(message.TurringMethod("anyKey"));

    }
    }
