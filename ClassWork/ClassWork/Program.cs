using ClassWork.Models;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student { 
              Name="saBIR",
              Surname="gUliYEV",
              Age=27
            
            };
            Student student2 = new Student
            {
                Name = "Nazrin",
                Surname = "Abbasova",
                Age = 19

            };
            Student student3 = new Student
            {
                Name = "Tabriz",
                Surname = "Necefov",
                Age = 20

            };
            Student student4 = new Student
            {
                Name = "Konul",
                Surname = "Meherremzade",
                Age = 25

            };


            Group group = new Group {Name="PB306" };
            Group group2 = new Group {Name="PF505" };

            group.AddStudent(student);
            group.AddStudent( student2);


            group2.AddStudent(student3);
            group2.AddStudent(student4);



            Console.WriteLine(group.Name+":");

            group.ShowStudents();
            Console.WriteLine("-----------------------------");

            Console.WriteLine(group2.Name+":");
            group2.ShowStudents();



        }
    }
}
