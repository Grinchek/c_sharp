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
            int[,] array = new int[3, 3];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[0, 2] = 3;

            array[1, 0] = 4;
            array[1, 1] = 5;
            array[1, 2] = 6;

            array[2, 0] = 7;
            array[2, 1] = 8;
            array[2, 2] = 9;

            Console.Write(array[0, 0] + " ");
            Console.Write(array[0, 1] + " ");
            Console.Write(array[0, 2] + " ");
            Console.WriteLine();
            Console.Write(array[1, 0] + " ");
            Console.Write(array[1, 1] + " ");
            Console.Write(array[1, 2] + " ");
            Console.WriteLine();
            Console.Write(array[2, 0] + " ");
            Console.Write(array[2, 1] + " ");
            Console.Write(array[2, 2] + " ");
            Console.WriteLine();

            //2
            int[,] array2= new int[3, 4];
            for(int i = 0; i < array2.GetLength(0); i++)
            {
                for(int j=0;j< array2.GetLength(1); j++)
                {
                    array2[i, j] = i * j + 1;
                }
            }
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i,j]+" "  );
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}