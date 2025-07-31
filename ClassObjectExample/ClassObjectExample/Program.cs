using ClassObjectExample.Models;

namespace ClassObjectExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Anonymous Object
            //var person = new
            //{
            //    Name = "Nasib",
            //    Surname = "Shahverdiyev",
            //    Age = 27,
            //    IsSingle = true
            //};

            //object person2 = new
            //{
            //    Fullname = "Shabnam Zeynalli",
            //    Grade = 3,
            //    Fincode = "gasgd43ds"
            //};

            //Console.WriteLine(person.Age); 
            #endregion

            //Person person4 = new Person("Salam","Salamov",17,true);



            //Person person = new Person("Nasib","Shahverdiyev",27,true);


            //person.Surname = "Shahverdiyev";
            //person.Age = 27;
            //person.IsSingle = false;


            //person.PrintInfo();




            //Person person2= new Person("Shabnam");


            //person2.Surname = "Zeynalli";
            //person2.Age = 25;
            //person2.IsSingle = true;


            //person2.PrintInfo();



            //Person person3= new Person("Sabir","Guliyev");
            //person3.PrintInfo();








            //Student student = new Student("Test");

            //student.Surname="Testov";
            //student.Age= 30;
            //student.PrintInfo();
            //student.UniversityName = "Aztu";
            //student.FacultyName = "Tourism";
            //student.Grade = 3;

            //Teacher teacher= new Teacher();
            //teacher.Name = "Sabir";
            //teacher.Surname = "Guliyev";
            //teacher.Age = 27;
            //teacher.IsSingle = true;

            //teacher.Profession = "Backend";
            //teacher.Experience = 3;
            //teacher.Salary = 765432.90m;



            //Student student = new Student("Test") {
            //    Surname = "Testova",
            //    Age = 12,
            //    IsSingle = true
            //};

            

        }

    }

    class Person
    {
        //Fields
        public string Name;
        public string Surname;
        public int Age;
        public bool IsSingle;



        //Constructor

        //public Person(string name)
        //{
        //    Console.WriteLine("Person ctor ishe dushdu");
        //    Name= name;
        //}


        #region Constructor Overload
        //public Person()
        //{
        //    Console.WriteLine("Person created");
        //}


        //public Person(string name) : this()
        //{

        //    Name = name;
        //}


        //public Person(string name, string surname) : this(name)
        //{
        //    Surname = surname;
        //}

        //public Person(string name, string surname, int age) : this(name, surname)
        //{
        //    Age = age;
        //}

        //public Person(string name, string surname, int age, bool isSingle) : this(name, surname, age)
        //{
        //    IsSingle = isSingle;
        //} 
        #endregion
        //Method 
        public void  PrintInfo()
        {

            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age} Is Single: {IsSingle}");
           
        }
    }

}
