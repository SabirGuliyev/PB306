using UpcastingExample.Models;

namespace UpcastingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator overload

            Manat manat = new Manat(100);
            Manat manat2 = new Manat(500);
            Manat manat3 = new Manat(500);
            Dollar dollar = new Dollar(200);


            manat = manat + manat2 + manat3;
            Console.WriteLine(manat.AZN);










            //Manat manat2 = 500m;

            //Console.WriteLine(manat2.AZN);


            //Manat manat2 = dollar;
            //Dollar dollar2 = manat;

            //Console.WriteLine(dollar2.USD);


            #endregion


            #region Boxing unboxing
            //byte num = 200;
            //int num2 = num;

            int num = 20;

            object box = num;

            Console.WriteLine(box);
            //object box2 =
            //{
            //    20
            //}

            //int num2 = (int)box;

            #endregion


            #region Upcasting Downcasting
            //implicit
            //Animal animal = new Eagle
            //{
            //    AvgLifeTime=20,
            //    Gender="female",
            //    FlySpeed=150,
            //    ClawPower=500
            //};

            //Animal animal2 = new Dog
            //{
            //    AvgLifeTime = 15,
            //    Gender = "male",
            //    Name = "Max",
            //};


            //Animal[] animals = { animal, animal2 };
            //foreach (Animal item in animals)
            //{
            //    if(item is Eagle eagle)
            //    {
            //        Console.WriteLine(eagle.FlySpeed);
            //    }
            //    else if(item is Dog dog)
            //    {
            //        Console.WriteLine(dog.Name);
            //    }
            //}
            //PrintAverage(animal);
            //PrintAverage(animal2);

            //Explicit operator

            //Dog dog = (Dog)animal2;

            //As operator


            //Eagle eagle = animal as Eagle;

            //if(eagle != null)
            //{
            //    Console.WriteLine(eagle.FlySpeed);
            //}
            //else
            //{
            //    Console.WriteLine("Casting failed");
            //}

            //is ile cast etmek(is cast operatoru deyil!)
            //if (animal2 is Eagle eagle)
            //{
            //    Console.WriteLine(eagle.FlySpeed);
            //}
            //else if(animal2 is Dog dog)
            //{
            //    Console.WriteLine(dog.Name);
            //} 
            #endregion

        }

        //public static void PrintAverage(Animal animal)
        //{
        //    Console.WriteLine(animal.Gender+" "+animal.AvgLifeTime);
        //}
    }
}
