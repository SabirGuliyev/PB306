namespace MethodExampe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int product = 90;
            //int discount = 10;
            //Console.WriteLine(product*discount/100);

            //int product2 = 120;
            //int discount2 = 20;
            //Console.WriteLine(product2*discount2/100);
            //int product = 150;


            //int product = 150;

            //int discountedValue = GetDiscount(product, 20);

            //product-=discountedValue;
            //Console.WriteLine(product);







            //int num = 24;

            //    if (IsEven(num))
            //    {
            //        Console.WriteLine("Cutdur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekdir");
            //    }



            //int[] nums = { 12, 15, 18 };

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (IsEven(nums[i]))
            //    {
            //        Console.WriteLine("Cutdur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekdir");
            //    }
            //}


            //GetFullname("Test");


            //string[] text = { "Salam", "Necesiz", "Gencler" };
            //CreateSentence(text);

            CreateSentence("Salam", "Gencler", "Necesiz");
            CreateSentence();
        }

        public static void CreateSentence(params string[] words)
        {
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                sentence+= words[i];
                sentence+= " ";
            }

            Console.WriteLine(sentence);
        }





        public static void GetFullname(string name,string surname="xxx")
        {
            Console.WriteLine(name+" "+surname);
        }


        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
               
            }
            return false;
        }



        public static int GetDiscount(int price, int percent)
        {
            int result = price * percent / 100;
            return result;

        }
    }
}
