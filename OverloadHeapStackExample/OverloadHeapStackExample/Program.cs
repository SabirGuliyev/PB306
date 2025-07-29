using System;

namespace OverloadHeapStackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = 5;
            //int b = a;

            //b += 10;
            ////Console.WriteLine(a);

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = arr;

            //arr2[0] = 70;

            //Console.WriteLine(arr==arr2);

            //Console.WriteLine(arr==arr2);

            //int a = 5;
            //ChangeValue(a);

            //Console.WriteLine(a);
            //int[] arr = { 1, 2, 3 };
            //ChangeIndex(arr);
            //Console.WriteLine(arr[0]);


            //int test = 40;


            //if (true)
            //{
            //    int a = 10;
            //    if (true)
            //    {
            //        int b = 20;
            //        if (true)
            //        {
            //            int[] arra = { 1, 2 };
            //            Console.WriteLine("1ci merhele"+b);
            //            Console.ReadKey();
            //        }
            //    }
            //}
            //Console.WriteLine("Son merhele");
            //Console.ReadKey();

            //int a=0;
            //ChangeValue(out a);
            //Console.WriteLine(a);

            //string str = Console.ReadLine();
            //int a;
            //bool result=int.TryParse(str, out a);

            //if (result)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}

                  //0x01
            int[] arr = {1,2,3, 4, 5, 6 };

            ResetArray(ref arr);

                                //0x02
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static void ResetArray(ref int[] nums)
        {
            //0x01   //0x02
            nums = new int[nums.Length];//{0,0,0,0,0,0,0}
        }

        public static void ChangeValue(out int num)
        {

            num = 10;
            num -= 5;
        }
        public static void ChangeIndex(int[] nums)
        {
            nums[0] += 70;

        }


        #region Method Overload
        //public static void Sum(int num)
        //{
        //    Console.WriteLine("1ci method ishe dushdu");
        //}
        //public static void Sum(int num=5, int num2=10)
        //{
        //    Console.WriteLine("2ci method");
        //}

        //public static void Sum(params int[] nums)
        //{
        //    Console.WriteLine("3ci");
        //}










        //public static void Sum(double num, int num2)
        //{
        //    Console.WriteLine("3cu");
        //}
        //public static void Sum(int num, double num2)
        //{
        //    Console.WriteLine("3cu");
        //} 
        #endregion
    }
}
