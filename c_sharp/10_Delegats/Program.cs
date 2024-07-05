namespace _c_sharp_
{
    class Program
    {

        public delegate int CalculateArray(int[] nums);
        public delegate void ChangeArray(int[] nums);
        public static int SummaOfElements(int[] nums)
        {
            return nums.Sum();
        }
        public static int SummaOfNegativeElements(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }
        public static int SummaOfSimpleNumbers (int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 1)
                {
                    int indicator = 0;
                    for(int j = 2; j < nums[i];j++)
                    {
                        if (nums[i] % j == 0)
                        {
                            indicator++;
                        }
                    } 
                    if (indicator == 0)
                    {
                        sum += nums[i];
                    }
                }
            }
            return sum;
        }
        public static void DeleteNegativeElements(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = 0;
                }
            }
            foreach(int item in nums)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }
        public static void MySort(int[] nums)
        {
            Array.Sort(nums);
            foreach (int item in nums)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }
        public static void MenuWrap()
        {
            Console.WriteLine("Select operation:\n1.Calculate array.\n2.Change array.");

        }
        public static void InnerCalcMenu()
        {
            CalculateArray[] calculateArray = new CalculateArray[3];
            calculateArray[0] = SummaOfElements;
            calculateArray[1] = SummaOfNegativeElements;
            calculateArray[2] = SummaOfSimpleNumbers;
            Console.WriteLine("Select operation:\n1.Summa of all elements." +
                "\n2.Summa of negative elements." +
                "\n3.Summa of simple numbers.");
            int invokeNumber=int.Parse(Console.ReadLine())-1;
            calculateArray[invokeNumber].Invoke(nums);

        }
        public static void InnerChangeMenu()
        {
            ChangeArray[] changeArray = new ChangeArray[2];
            changeArray[0] = DeleteNegativeElements;
            changeArray[1] = MySort;
            Console.WriteLine("Select operation:\n1.Calculate array.\n2.Change array.");

        }
      
        public static void Main(string[] args)
        {
            int[] nums =new int[10];
            for (int i = 0;i < nums.Length; i++)
            {
                nums[i] = new Random().Next(40)-20;
            }
            
            











        }
    }
}
