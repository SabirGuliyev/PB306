using DelegateExample.Models;
using System.Threading.Channels;

namespace DelegateExample
{
    //public delegate bool CheckNum(int value);

    //public delegate void Print(string str);

    internal class Program
    {

        static void Main(string[] args)
        {
            #region Pair Task
            //Pair<string, string> pair = new();

            //pair.Add(new Pair<string, string> { Key = "a", Value = "anar" });
            //pair.Add(new Pair<string, string> { Key = "b", Value = "Banan" });
            //pair.Add(new Pair<string, string> { Key = "c", Value = "Banan" });


            //Console.WriteLine(pair.Pairs.Length); 
            #endregion


            //CheckNum check = IsEven;
            //check += IsOdd;
            //check += IsDividedByThree;

            //Console.WriteLine(check(7));



            //Action<string> print = PrintUpper;

            //print += PrintLower;
            //print -=x=> Console.WriteLine(x.ToLower());

            //print.Invoke("Salam");
            //SumOfArray(arr, IsEven);
            //SumOfArray(arr, IsOdd);
            //SumOfArray(arr, IsDividedByThree);
            //SumOfArray(arr, IsDivided);


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 15, 30 };



            //Func<int> func = x => x % 2 == 0;

            //Func<string, char, int, double> func1 = (x, y, z) => 0.5d;

            //Action<string> action = ;



            //SumOfArray(arr, delegate (int num)
            //{
            //    return num < 3;
            //});

            //SumOfArray(arr, x => x % 2 == 0);
            //SumOfArray(arr, x => x % 7 == 0);
            //SumOfArray(arr, x => x < 10);






            List<Student> students = new List<Student>
            {
                new Student{ Name="Eynulla",Grade=97},
                new Student{ Name="Nasib",Grade=49},
                new Student{ Name="Vugar",Grade=20},
                new Student{ Name="Nazrin",Grade=67}

            };

            students=students.OrderByDescending(s => s.Grade).ToList();
            //students.RemoveAll(s => s.Grade < 50);
            //students.FindAll(s => s.Grade < 50);

            students.ForEach(s => Console.WriteLine(s.Name));

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}


        }

        public static void SumOfArray(int[] arr, Predicate<int> method)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (method(arr[i]))
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }


        //public static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
        //public static bool IsOdd(int num)
        //{
        //    return num % 2 != 0;
        //}
        //public static bool IsDividedByThree(int num)
        //{
        //    return num % 3 == 0;
        //}


        public static void PrintUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }
        public static void PrintLower(string word)
        {
            Console.WriteLine(word.ToLower());
        }

        public static void PrintCapitalize(string word)
        {
            Console.WriteLine(word[0]);
        }













    }
}
