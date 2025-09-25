using EFExample.DAL;
using EFExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext context = new AppDbContext();




            List<Student> students = context.Students.ToList();

            // foreach (var student in students)
            // {
            //     Console.WriteLine(student.Name+" "+student.Surname);
            // }















            //Student student = new Student
            //{
            //    Name = "Test",
            //    Surname = "Testov",
            //    Age = 30

            //};

            //context.Students.Add(student);

            //context.SaveChanges();







            //Student student = context.Students.Include(s=>s.Group).FirstOrDefault(s => s.Id == 2);



            //Console.WriteLine(student.Name+" "+student.Group.Name);






            //student.Name = "Salam2";

            //context.Students.Remove(student);


            //context.SaveChanges();



            //context.Students.Update(student);


            //if(student is null)
            //{
            //    Console.WriteLine("Bele bir telebe tapilmadi");
            //    return;
            //}

            //Console.WriteLine(student.Name);
            Group group = context.Groups.Include(g=>g.Students).FirstOrDefault(g => g.Id == 1);
            Console.WriteLine(group.Name);
            Console.WriteLine("---------------------");

            foreach (var item in group.Students)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
