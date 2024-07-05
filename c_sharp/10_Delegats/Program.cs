using System.Threading.Channels;

namespace _c_sharp_
{
    class Program
    {
        public delegate void OuterDelegate(int[] nums);
        public delegate int CalculateArray(int[] nums);
        public delegate void ChangeArray(int[] nums);
        public static int SummaOfElements(int[] nums)
        {
            Console.WriteLine("Summa of all elements: ");
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
            Console.WriteLine("Summa of negative elements: ");
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
            Console.Write("Summa of simple numbers: ");
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
            Console.WriteLine("Array without negative elements.");
            foreach(int item in nums)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }
        public static void MySort(int[] nums)
        {
            Array.Sort(nums);
            Console.WriteLine("Sorted array.");
            foreach (int item in nums)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }
        public static void InnerCalcMenu(int[] nums)
        {
            CalculateArray[] calculateArray = new CalculateArray[3];
            calculateArray[0] = SummaOfElements;
            calculateArray[1] = SummaOfNegativeElements;
            calculateArray[2] = SummaOfSimpleNumbers;
            Console.WriteLine("Select operation:\n1.Summa of all elements." +
                "\n2.Summa of negative elements." +
                "\n3.Summa of simple numbers.");
            int invokeNumber=int.Parse(Console.ReadLine())-1;
            invokeNumber = (invokeNumber >= 0 && invokeNumber <= 2) ? invokeNumber : throw new Exception("Wrong choice");
            Console.WriteLine(calculateArray[invokeNumber].Invoke(nums)); 

        }
        public static void InnerChangeMenu(int[] nums)
        {
            ChangeArray[] changeArray = new ChangeArray[2];
            changeArray[0] = DeleteNegativeElements;
            changeArray[1] = MySort;
            Console.WriteLine("Select operation:\n1.Delete negative elements.\n2.Sort array.");
            int invokeNumber= int.Parse(Console.ReadLine())- 1;
            invokeNumber=(invokeNumber >= 0 && invokeNumber <= 1) ? invokeNumber : throw new Exception("Wrong choice");
            changeArray[invokeNumber].Invoke(nums);

        }
        public static void OuterMenu(int[] nums) {
            OuterDelegate[] outerDelegates = new OuterDelegate[2];
            outerDelegates[0]= InnerCalcMenu;
            outerDelegates[1]= InnerChangeMenu;
            Console.WriteLine("Select operation:\n1.Calculate array.\n2.Change array.");
            int invokeNumber = int.Parse(Console.ReadLine())-1;
            invokeNumber = (invokeNumber >= 0 && invokeNumber <= 2) ? invokeNumber : throw new Exception("Wrong choice");
            outerDelegates[invokeNumber].Invoke(nums);
            

        }
      
        public static void Main(string[] args)
        {
            int[] nums =new int[10];
            bool ex= false;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(40) - 20;
            }
            while (!ex)
            {
                try
                {
                    OuterMenu(nums);
                    Console.WriteLine("To exit - press 0\nTo continue - press any digit");
                    int quit=int.Parse(Console.ReadLine());
                   if(quit == 0)
                    {
                        ex= true;
                    }
                    else
                    {
                        ex = false;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

       
            


            
            











        }
    }
}
