namespace _c_sharp_
{
    class Program
    {
        public delegate void ChangeArray(int[] numns);
        public delegate int CalculateArray(int[] numns);
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
        }
        public static void MySort(int[] nums)
        {
            Array.Sort(nums);
        }
      
        public static void Main(string[] args)
        {
            int[] nums =new int[10];
            for (int i = 0;i < nums.Length; i++)
            {
                nums[i] = new Random().Next(40)-20;
            }
            ChangeArray changeArray=null;
            changeArray += DeleteNegativeElements;
            changeArray += MySort;
            changeArray.GetInvocationList();
            




        }
    }
}
