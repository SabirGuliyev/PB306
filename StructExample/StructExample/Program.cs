using StructExample.Models;
using StructExample.Utilities.Enums;
using StructExample.Utilities.Extensions;
using System.Threading.Channels;

namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Student Task
            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();

            //if (Student.CheckName(name) && Student.CheckName(surname))
            //{
            //    Student student = new Student(name,surname);
            //    Console.WriteLine(student.CodeEmail);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Input");
            //} 
            #endregion

            #region Struct

            //PointClass point = new PointClass
            //{
            //    X = 3,
            //    Y = 5
            //};


            //PointStruct pointStruct = new PointStruct
            //{
            //    X = 3,
            //    Y = 5
            //};


            //Console.WriteLine(point);
            //Console.WriteLine(pointStruct);


            //TestPoint(point);
            //TestPoint(ref pointStruct); 
            #endregion

            #region Enum


            //var type=;

            //var values=;
        

            foreach (var day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine((int)day + " " + day);
            }

            int num;
            string str = Console.ReadLine();
            int.TryParse(str, out num);





            switch (num)
            {
                case (int)WeekDay.Monday:
                    Console.WriteLine(WeekDay.Monday);
                    break;

                case (int)WeekDay.Tuesday:
                    Console.WriteLine(WeekDay.Tuesday);
                    break;

                case (int)WeekDay.Wednesday:
                    Console.WriteLine(WeekDay.Wednesday);
                    break;

                case (int)WeekDay.Thursday:
                    Console.WriteLine(WeekDay.Thursday);
                    break;

                case (int)WeekDay.Friday:
                    Console.WriteLine(WeekDay.Friday);
                    break;

                case (int)WeekDay.Saturday:
                    Console.WriteLine(WeekDay.Saturday);
                    break;

                case (int)WeekDay.Sunday:
                    Console.WriteLine(WeekDay.Sunday);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }





            //Student student = new Student("Test", "Testov",Gender.Male);


            //switch (num)
            //{
            //    case (int)Gender.Male:
            //        student.Gender = Gender.Male;
            //        break;
            //    case (int)Gender.Female:
            //        student.Gender=
            //}

            //Console.WriteLine(student.Gender);




            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;

            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong input");
            //        break;
            //} 
            #endregion


            //string str = "Sabir123";
            //Console.WriteLine(str.CheckPassword());


            int[] numbers = { 1, 2, 3, 4 };


            foreach (var test in numbers)
            {

            }
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    int num = numbers[i];


            //    Console.WriteLine(num);
            //}


            int result = TestPoint(new PointClass());
          

          





            




        }

        public static int TestPoint(PointClass cordination)
        {
            Console.WriteLine("Ok");
            return 6;
        }
        //public static void TestPoint(ref PointStruct cordination)
        //{
        //    Console.WriteLine("Ok");
        //}
    }
}
