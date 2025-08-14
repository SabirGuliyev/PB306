using IndexerExample.Models;
using System;

namespace IndexerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //Student student = new Student 
            //{
            //    Name="Eynulla",
            //    FinCode="a1"
            //};
            //Student student2 = new Student
            //{
            //    Name = "Aytac",
            //    FinCode = "b2"
            //};
            //Student student3 = new Student
            //{
            //    Name = "Nazrin",
            //    FinCode = "c3"
            //};

            //Group group = new Group
            //{
            //    Name = "PB306",
            //    Students = new Student[] { student, student2, student3 }
            //};


            //foreach (Student stu in group.Students)
            //{
            //    Console.WriteLine(stu);
            //}
            //int[] arr = { 1, 5, 7, 12 };



            //Console.WriteLine();
            //
            //int[] nums = { 1,2,3,4,5,6,};


            //Console.WriteLine(nums[30]);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //Console.WriteLine("-------------------------------------");
            //ListInt numbers=new ListInt(1,2,3,4,5,6);

            //Console.WriteLine(numbers[30]);
            //numbers.Add(7);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine(nums[0]);
            //Console.WriteLine(numbers[0]); 
            #endregion



            int num;
            int num2;
            try
            {
               num = int.Parse(Console.ReadLine());
               num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num/num2);

                string name = "Salam";
                //Console.WriteLine(name[20]);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                num = 0;
                num2 = 1;
               
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                num2 = 1;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
            }
          
            Console.WriteLine("Kodumuz devam edir");
        }
    }
}
