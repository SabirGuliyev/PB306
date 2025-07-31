
namespace ClassObjectExample.Models
{
    internal class Student:Person
    {
        public string UniversityName;
        public int Grade;
        public string FacultyName;


        public Student(string name) 
        {
            Console.WriteLine("Student ctor ishe dushdu");
        }

    }

}
