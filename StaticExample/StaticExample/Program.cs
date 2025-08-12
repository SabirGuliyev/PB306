using StaticExample.Models;
using StaticExample.Utilities.Extensions;

namespace StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Program program = new Program();
            //    program.Sum();


            //Sum();
            #region Vehicle task
            //Car car = new Car
            //{
            //    FactoryName="Mercedes",
            //    Model="4 goz",
            //    Color="Black",
            //    DoorCount=4,
            //    DrivePath=300,
            //    DriveTime=2,
            //    IsElectric=false
            //};
            //Car car2 = new Car
            //{
            //    FactoryName = "Tesla",
            //    Model = "Uvenit",
            //    Color = "Red",
            //    DoorCount = 4,
            //    DrivePath = 200,
            //    DriveTime = 2,
            //    IsElectric = true
            //};


            //car.PrintInfo();
            //car.DefineNatureHarmness();

            //Console.WriteLine("----------");

            //car2.PrintInfo();
            //car2.DefineNatureHarmness();

            //Console.WriteLine("---------------------");

            //Bicycle bicycle=new Bicycle {
            //    FactoryName = "Desna",
            //    Model = "Forward",
            //    Color = "Red",
            //    DrivePath = 80,
            //    DriveTime = 2,
            //    Type="Mountain"
            //};


            //bicycle.PrintInfo();
            //bicycle.DefineNatureHarmness();


            //Vehicle[] vehicles = { car, car2, bicycle };

            //for (int i = 0; i < vehicles.Length; i++)
            //{
            //    vehicles[i].PrintInfo();
            //    Console.WriteLine("-------------------------------");
            //}

            #endregion







            Person person = new Person
            {
                Name = "Test",
                Surname = "Testov"

            };

            Person person2 = new Person
            {
                Name = "Sabir",
                Surname = "Guliyev"

            };

            Person person3 = new Person
            {
                Name = "Revan",
                Surname = "Guliyev"

            };
            Person person4 = new Person
            {
                Name = "Tabriz",
                Surname = "Guliyev"

            };

            //person.PrintInfo();
            //person2.PrintInfo();
            //person3.PrintInfo();
            //person4.PrintInfo();




            int num = 5;

            Console.WriteLine(num.Power(4));

            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();

           


        }




        public static void Sum()
        {
            Console.WriteLine("Salam");
        }
    }
}
