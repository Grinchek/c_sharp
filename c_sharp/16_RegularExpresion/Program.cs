using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //  #1
        string filePath = "..//..//..//text.txt";
        string fileContent = File.ReadAllText(filePath);

        string pattern = @"\d+(\.\d+|,\d+)";
        var matches = Regex.Matches(fileContent, pattern);

        Console.WriteLine("Fractional numbers:");
        foreach (var match in matches)
        {
            Console.Write($"[{match}]");
        }
        Console.WriteLine();

        // #2
        List<int> integers = new List<int>();
        string intPattern = @"-?\d+";
        var intMatches = Regex.Matches(fileContent, intPattern);

        foreach (Match match in intMatches)
        {
            if (int.TryParse(match.Value, out int number))
            {
                integers.Add(number);
            }
        }

        Console.WriteLine("\nIntegers:");
        foreach (var number in integers)
        {
            Console.Write($"[{number}]");
        }
        Console.WriteLine();

        //#3
        var positiveNumbers = integers.Where(x => x > 0).OrderBy(x => x).ToList();

        Console.WriteLine("\nSorted positive numbers:");
        foreach (var number in positiveNumbers)
        {
            Console.Write($"[{number}]");
        }
        Console.WriteLine();

        // #4
        var positiveTwoDigitNumbers = integers.Where(x => x >= 10 && x < 100).ToList();

        int count = positiveTwoDigitNumbers.Count;
        double average = positiveTwoDigitNumbers.Average();

        Console.WriteLine($"\nNumber of positive two-digit numbers: {count}");
        Console.WriteLine($"Average of positive two-digit numbers: {average}");
    }
}