using System.Globalization;
using System.Linq;

namespace _c_sharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region One dimension
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //arr.SetValue(77, 2);
            //arr.SetValue(88, 0);
            //foreach (var element in arr)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
            #region Two dimension
            //int[,] array = new int[3, 3];
            //array[0, 0] = 1;
            //array[0, 1] = 2;
            //array[0, 2] = 3;

            //array[1, 0] = 4;
            //array[1, 1] = 5;
            //array[1, 2] = 6;

            //array[2, 0] = 7;
            //array[2, 1] = 8;
            //array[2, 2] = 9;

            //Console.Write(array[0, 0] + " ");
            //Console.Write(array[0, 1] + " ");
            //Console.Write(array[0, 2] + " ");
            //Console.WriteLine();
            //Console.Write(array[1, 0] + " ");
            //Console.Write(array[1, 1] + " ");
            //Console.Write(array[1, 2] + " ");
            //Console.WriteLine();
            //Console.Write(array[2, 0] + " ");
            //Console.Write(array[2, 1] + " ");
            //Console.Write(array[2, 2] + " ");
            //Console.WriteLine();

            ////2
            //int[,] array2 = new int[3, 4];
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        array2[i, j] = i * j + 1;
            //    }
            //}
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Random random = new Random();
            // # 1 
            //int[] arr = new int[10];
            //int iven = 0;
            //int odd = 0;
            //int uniq = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(10);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        iven++;
            //    }
            //    else
            //    {
            //        odd++;
            //    }
            //}
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //    int counter = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i!=j&&arr[i] == arr[j])
            //        {
            //            counter++;

            //        }

            //    }
            //    if (counter == 0)
            //    {
            //        uniq++;
            //    }

            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]+" ");
            //}
            //Console.WriteLine("Even: "+iven);
            //Console.WriteLine("Odd: "+odd);
            //Console.WriteLine("Uniq: "+uniq);

            // #2

            //int[] arr = new int[10];
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(10);
            //}
            //Console.Write(  "Enter wanted number: ");
            //string st = Console.ReadLine();
            //int num =int.Parse(st);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < num)
            //    {
            //        count++;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"[{arr[i]}]");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"There are {count}, numbers, less than {num}");

            // #3

            double maximum = 0;
            double minimum = 0;
            double summa = 0;
            double product = 0;
            int pairAsumma = 0;
            double oddBrowSumma = 0;
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Console.WriteLine("Fill the array (5 integers)");
            for (int i=0;i<A.Length;i++)
            {
                string input = Console.ReadLine();
                A[i]=int.Parse(input);

            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"[{A[i]}]");
            }
            Console.WriteLine("\n===============================");
            for (int i = 0;i< B.GetLength(0);i++) {
                for(int j=0;j<B.GetLength(1);j++)
                {
                    B[i,j] = random.Next(10)+ random.NextDouble();
                    B[i, j]= Math.Round(B[i, j],2);
                    Console.Write($"[{B[i,j]}]");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine($"");


        }
    }
}