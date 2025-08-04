
namespace AccessModifiersExample.Models
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;
        public Student(string name,string surname,string group,int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = point >= 65;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} surname: {Surname} group; {Group} point; {Point}");
        }
        public void CheckGraduation()
        {
            if(IsGraduated)
            {
                Console.WriteLine("telebe mezun olub");
            }
            else
            {
                Console.WriteLine("telebe mezun olmayib");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point >= 65 && Point < 85)
            {
                Console.WriteLine("telebe adi diplem alib");
            }
            else if (Point >=85 && Point <95)
            {
                Console.WriteLine("telebe seref diplom alib");
            }
            else if(Point >= 95)
            {
                Console.WriteLine("telebe yuksek seref");
            }
            else
            {
                Console.WriteLine("telebe mezun olmayib");
            }
        }
    }
}
