
//using A=PolymorphAbstractionExample.Models.Salam.Alekum;

namespace PolymorphAbstractionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Person person = new Person();
            //string str= person.Test;

            //A.Person person2=new Models.Salam.Alekum.Person();
            // person2.PrintInfo();


            #region Book Task
            //Book book = new Book { Name = "A", Author = "Tolstoy", IsAvailable = true};
            //Book book2 = new Book { Name = "B", Author = "Tolstoy", IsAvailable = true};
            //Book book3 = new Book { Name = "C", Author = "Martin", IsAvailable = true};

            //BookLibrary library=new BookLibrary {Name="Elektron merkezi kitabxana" };

            //library.Add(book);
            //library.Add(book2);
            //library.Add(book3);

            //Console.WriteLine("Before Delete---------------------");
            //library.ShowAll();


            //library.Remove("B");
            //Console.WriteLine();
            //Console.WriteLine("After delete------------------");

            //library.ShowAll(); 
            #endregion


            Person person = new Person
            {
                Name = "Zulfuqar",
                Surname = "Aliyev"

            };


            Student student = new Student
            {
                Name = "Vuqar",
                Surname = "Aliyev",
                UniName = "AzTU",
                Grade = 3
            };




            //Console.WriteLine(person);
            //Console.WriteLine(student);



            //person.PrintInfo();
            //studen.PrintInfo();


            //Sum(1);
            //Sum(1,2);
            //Sum(1,2d);

        }

        public static void Sum(int num)
        {
            Console.WriteLine("1ci method");
        }
        public static void Sum(int num, int num2)
        {
            Console.WriteLine("2ci method");
        }
        public static void Sum(int num, double num2)
        {
            Console.WriteLine("3cu method");
        }
    }
}
