

using System.Text;

namespace StringArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Array.Resize();

            //{1,2,3}
            //{1,2,3,7}

            //int[] arr = {1,2,3};

            //Array.Resize(ref arr, arr.Length + 1);
            //arr[arr.Length-1] = 7;
            //CustomResize(ref arr, 20);
            //CustomResize(ref arr, 40);
            //CustomResize(ref arr, 50);
            //CustomResize(ref arr, 300);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int a = 5;
            //Quadratic(ref a);

            //Console.WriteLine(a);



            //string word = "Salam necesiz camahat";
            ////word=word.Trim();
            ////word.ToLower()
            ////word.ToUpper()
            ////word.Replace("050","+994-50")
            ////word.Contains(" nece")
            ////word.StartsWith("Sa")
            ////word.EndsWith("siz");
            ////word.LastIndexOf("g")
            ////word.Substring(word.LastIndexOf("."))
            ////word.Substring(6,5)
            //// word.Split(' ');

            ////string.Concat(name, " ", surname)

            //string[] arr = { "Salam", "Gencler", "Nece", "Gedir" };

            //string.Join(" askhvdjasvd ", arr);

            //Console.WriteLine();



            //string test = "salam";
            //string test2 = "salam";

            //test2 += " necesiz";

            //Console.WriteLine(test);


            //string test = "a";


            //for (int i = 0; i < 100; i++)
            //{
            //    test += "a";
            //    Console.WriteLine(test);
            //}

           



            string test=Console.ReadLine().Trim();
            
            Console.WriteLine(Capitalize(test));
        }
        //saBiR
        public static string Capitalize(string name)
        {
                          //Sabir
            StringBuilder str = new StringBuilder();
            str.Append(Char.ToUpper(name[0]));
            for(int i = 1; i < name.Length; i++)
            {
                str.Append(Char.ToLower(name[i]));
            }


            char symb = 'b';
            Char.IsUpper(symb);
            Char.IsLower('a');
            Char.IsDigit('a');
            Char.IsLetter('a');
            Char.IsSymbol('a');

            return str.ToString();




        }






        //public static void Quadratic(ref int num)
        //{
        //    num *= num;
        //}
        //public static void CustomResize(ref int[] nums,int num)
        //{
        //    int[] newNums = new int[nums.Length + 1];

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        newNums[i] = nums[i];
        //    }
        //    newNums[newNums.Length - 1] = num;
        //    nums=newNums;
        //}














        //public static void Area(int radius)
        //{
        //    int pi = 3;
        //    int s = pi * radius*radius;
        //}
        //public static void Area(int wide, int length)
        //{
        //    int S=wide*length;
        //}
        //public static void Area(int wide, int length, int heigth)
        //{
        //    int S =2*((wide*length) +(wide*heigth)+(length*heigth));
        //}
        //public static void Area(int a, int b, int c,int r)
        //{
        //    int P =(a+b+c)/2;
        //    int S = P * r;
        //}
    }
}
