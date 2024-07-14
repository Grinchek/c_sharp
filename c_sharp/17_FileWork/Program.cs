using System;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text.RegularExpressions;
namespace _c_sharp_
{

    class Program
    {
        static void Main(string[] args)
        {
            #region first task

            //Console.WriteLine("Enter the file name:");
            //Console.ReadLine();
            //string filePath= @"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\Text.txt";


            //if (File.Exists(filePath))
            //{
            //    try
            //    {
            //        string fileContent = File.ReadAllText(filePath);
            //        Console.WriteLine("File content:");
            //        Console.WriteLine(fileContent);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error durring reading the file: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist.");
            //}
            #endregion
            #region second task
            //string[] strings = new string[5];
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    strings[i] = Console.ReadLine();
            //}
            //string filePath = @"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\array.json";
            //string jsonString=JsonSerializer.Serialize(strings);
            //File.WriteAllText(filePath, jsonString );

            #endregion
            #region thihrd task
            //string filePath = @"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\array.json";
            //string jsonString=File.ReadAllText(filePath);
            //string[] strings = JsonSerializer.Deserialize<string[]>(jsonString);
            //foreach(string word in strings)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region fourth task



            //int[] numbers = new int[10000];
            //const string evenFilePath= @"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\evenNumbers.txt";
            //const string oddFilePath = @"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\oddNumbers.txt";

            //Random random = new Random();


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next();
            //}

            //var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            //var oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();
            //File.WriteAllLines(evenFilePath, evenNumbers.Select(n => n.ToString()));
            //File.WriteAllLines(oddFilePath, oddNumbers.Select(n => n.ToString()));

            //Console.WriteLine("Statistic:");
            //Console.WriteLine("Amount of numbers: 10000");
            //Console.WriteLine($"Amount of even numbers: {evenNumbers.Length}");
            //Console.WriteLine($"Amount if odd numbers: {oddNumbers.Length}");




            #endregion
            #region fiveth task
            //string content = File.ReadAllText(@"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\Text.txt");
            //Console.WriteLine("Enter wanted word");
            //string word=Console.ReadLine();
            //MatchCollection matchCollection = Regex.Matches(content, word);
            //int counter = 0;
            //foreach (Match item in matchCollection)
            //{
            //    Console.WriteLine($"Index {item.Index} , Value {item.Value}");
            //    counter++;
            //}
            //Console.WriteLine($"There are {counter} matches");
            //string word2="";
            //for(int i = word.Length-1; i>=0;i--)
            //{
            //    word2 += word[i];
            //}
            //MatchCollection matchCollection2 = Regex.Matches(content, word2);
            //int counter2 = 0;
            //foreach (Match item in matchCollection2)
            //{
            //    Console.WriteLine($"Index {item.Index} , Value {item.Value}");
            //    counter2++;
            //}
            //Console.WriteLine($"There are {counter2} reverse matches");

            #endregion
            #region sixth task
            int counter = 0;
            string content = File.ReadAllText(@"C:\Users\User\Desktop\Нова папка\c_sharp\17_FileWork\Text.txt");
            // Checkig for sentences
            //MatchCollection matchSentences = Regex.Matches(content, @"((?:(?(?=(e.g.|z.b.|Figs?\.|\d+\.\d))\2|[^.!?])+[.!?]))");
            //foreach (Match match in matchSentences) { counter++; }
            //Console.WriteLine($"There are {counter} sentences in text.");

            // Checking for capital letters
            //MatchCollection matchCapitalLetters = Regex.Matches(content, @"[A-Z]");
            //foreach (Match match in matchCapitalLetters) { counter++; }
            //Console.WriteLine($"There are {counter} capital letters in text.");


            // Checking for lowercase letter
            //MatchCollection matchLowerCaseLetter = Regex.Matches(content, @"[a-z]");
            //foreach (Match match in matchLowerCaseLetter) { counter++; }
            //Console.WriteLine($"There are {counter} lowercase letters in text.");

            // Checking for vowel letters
            //MatchCollection matchVowerLetter = Regex.Matches(content, @"[aeiouAEIOU]");
            //foreach (Match match in matchVowerLetter) { counter++; }
            //Console.WriteLine($"There are {counter} vowel letters in text.");


            // Checking for consonant letters
            //MatchCollection matchCosonantLetter = Regex.Matches(content, @"[!(aeiouAEIOU)]");
            //foreach (Match match in matchCosonantLetter) { counter++; }
            //Console.WriteLine($"There are {counter} consonant letters in text.");


            // Checking for all digits
            //MatchCollection matchDigits = Regex.Matches(content, @"\d");
            //counter = 0;
            //foreach (Match match in matchDigits) { counter++; }
            //Console.WriteLine($"There are {counter} number in text.");

            #endregion
        }
    }
}
