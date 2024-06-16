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
            #region 1
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
            #endregion
            #region 2

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
            #endregion
            #region 3

            // #3

            //double maximum, minimum, summa, product;
            //double oddBrowSumma = 0;
            //int pairAsumma = 0;
            //int[] A = new int[5];
            //int row = 3;
            //int col = 4;
            //double[,] B = new double[row, col];
            //Console.WriteLine("Fill the array (5 integers)");
            //for (int i=0;i<A.Length;i++)
            //{
            //    A[i]=int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"[{A[i]}]");
            //}
            //Console.WriteLine("\n===============================");
            //for (int i = 0;i< B.GetLength(0);i++) {
            //    for(int j=0;j<B.GetLength(1);j++)
            //    {
            //        B[i,j] = random.Next(10)+ random.NextDouble();
            //        B[i, j]= Math.Round(B[i, j],2);
            //        Console.Write($"[{B[i,j]}]");
            //    }
            //    Console.WriteLine();
            //}
            //double tempMax=0;

            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for(int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i,j] > tempMax)
            //        {
            //            tempMax = B[i,j];
            //        }
            //    }
            //}
            //double tmpAmax=Convert.ToDouble( A.Max());
            //maximum=tmpAmax > tempMax ?tmpAmax : tempMax;
            //double tempMin = maximum;
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i, j] < tempMin)
            //        {
            //            tempMin = B[i, j];
            //        }
            //    }
            //}
            //double tmpAminx = Convert.ToDouble(A.Min());
            //minimum = tmpAminx < tempMin ? tempMin : tempMin;

            //double tmpASumma = Convert.ToDouble(A.Sum());
            //double tmpBSumma = 0;
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        tmpBSumma += B[i, j];
            //    }
            //}
            //summa = tmpASumma + tmpBSumma;

            //int aProduct = 1;
            //for(int i = 0; i < A.Length; i++)
            //{
            //    aProduct *= A[i];
            //}
            //double tmpAproduct = Convert.ToDouble(aProduct);
            //double tmpBproduct = 1;
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        tmpBproduct *= B[i, j];
            //    }
            //}
            //product = tmpAproduct + tmpBproduct;
            //product=Math.Round(product, 2);

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if ((i+1 )% 2 == 0)
            //    {
            //        pairAsumma += A[i];
            //    }
            //}
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if ((j+1)%2!=0)
            //        {
            //            oddBrowSumma += B[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"Minimum: {minimum}\nMaximum: {maximum}\n" +
            //    $"Summa: {summa}\nProduct: {product}\n"+
            //    $"Summa of pair element in array A: {pairAsumma}\n"+
            //    $"Summa of elements in odd rows in array B: {oddBrowSumma}");
            #endregion
            #region 4
            //int row = 5;
            //int col = 5;
            //double[,] B = new double[row, col];
            //int counter = 0;

            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i, j] = -100+random.Next(200) + random.NextDouble();
            //        B[i, j] = Math.Round(B[i, j], 2);
            //        Console.Write($"[{B[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}
            //double minimum = 0;
            //int minRow = 0; int minCol=0;
            //double maximum = 0;  
            //int maxRow = 0;int maxCol = 0;
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i, j] < minimum)
            //        {
            //            minimum = B[i, j];
            //            minRow = i;
            //            minCol = j;
            //        }
            //        if (B[i, j] > maximum)
            //        {
            //            maximum = B[i, j];
            //            maxRow = i;
            //            maxCol = j;
            //        }
            //    }
            //}
            //Console.WriteLine($"Minimum is: {minimum}, position[{minRow+1},{minCol+1}]"+
            //    $"\nMaximum is: {maximum}, position[{maxRow+1},{maxCol+1}]");
            //if((minRow > maxRow)||(minRow==maxRow&&minCol>maxCol))
            //{
            //    int tmpRow = minRow;
            //    int tmpCol = minCol;
            //    minRow = maxRow;
            //    minCol = maxCol;
            //    maxRow = tmpRow;
            //    maxCol = tmpCol;
            //}
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (i == minRow && j > minCol)
            //        {
            //            counter++;
            //        }
            //        if ((i>minRow&&i<=maxRow))
            //        {
            //            counter++;
            //        }

            //        if(i==maxRow && j == maxCol)
            //        {
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"There are {counter-1} elements between minimum and maximum.");
            #endregion
            #region 5
            //int row = 5;
            //int col = 5;
            //int[,] B = new int[row, col];
            //int counter = 0;

            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i, j] = -100 + random.Next(200);
            //        Console.Write($"[{B[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}
            //int minimum = 0;
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i, j] < minimum)
            //        {
            //            minimum = B[i, j];
            //        }
            //    }
            //}
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if ((B[i, j] == minimum+5)|| (B[i, j] == minimum -5 ))
            //        {
            //            counter++;
            //        }
            //    }
            //}
            //Console.WriteLine($"minimum is: {minimum}\n"+
            //    $"There are {counter} elements, different by 5 from mainimum.");
            #endregion

        }
    }
}