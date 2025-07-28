namespace Homework28._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetPower(5,1);

        }
        public static int GetMin(int[] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min= nums[i];
                }
            }
            return min;
        }

        public static int[] SortArray(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length - 1-i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp= nums[j];
                        nums[j]= nums[j + 1];
                        nums[j+1]= temp;
                    }
                }
            }
            return nums;
        }

        public static void GetPower(int num,int pow=2)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
               result *= num;
            }
            Console.WriteLine(result);
        }
    }

}
