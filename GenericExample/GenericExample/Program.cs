using GenericExample.Models;
using GenericExample.Zoo;

namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fruit Task
            //Fruit[] basket = new Fruit[3];

            //basket[0] = new Apple { VitaminA = 25, VitaminB = 50, Price = 0.40m, Sort = "Yasil Alma" };
            //basket[1] = new Orange { VitaminC = 30, Price = 0.80m, Sort = "Avropa portagali" };
            //basket[2] = new Pineapple { VitaminD = 15, VitaminE = 0, Price = 3m, Sort = "Afrika Ananasi" };


            //foreach (Fruit fruit in basket)
            //{
            //    Console.WriteLine($"{fruit.Sort}, {fruit.Price}");
            //    fruit.Taste();


            //    if (fruit is Apple apple)
            //    {
            //        Console.WriteLine($"VitaminA {apple.VitaminA}, VitaminB {apple.VitaminB}");
            //        Console.WriteLine();
            //    }
            //    else if (fruit is Pineapple pineapple)
            //    {
            //        Console.WriteLine($"VitaminD {pineapple.VitaminD}, VitaminE {pineapple.VitaminE}");
            //        Console.WriteLine();
            //    }
            //    else if (fruit is Orange orange)
            //    {
            //        Console.WriteLine($"Vitamin C {orange.VitaminC}");
            //        Console.WriteLine();
            //    }
            //}

            #endregion


            #region Product example

            //Product product = new Product(85);

            //product.Quality


            //Product product2 = new Product('A');
            //Product product3 = new Product("High");




            //Product<int> product = new Product<int>(90);

            //Product<char> product2 = new Product<char>('A');

            //Product<string> product3 = new Product<string>("High");




            //product.Quality += 5;



            //char.ToUpper(product2.Quality);




            //product3.Quality.Trim();


            #endregion

            //Student student = new Student { Name="Eynulla"};
            //Meat meat = new Meat {Calory=500,Type="beaf" };
            //Grass grass = new Grass { Calory=200,IsLegal=false};



            //Lion lion = new Lion {Name="Simba",AvgLifeTime=20,IsPrime=true };
            //Lion lion2 = new Lion {Name="Alex",AvgLifeTime=20,IsPrime=false };

            //ZooCage<Lion,Meat> zooCage = new ZooCage<Lion,Meat>(meat);
            //zooCage.Add(lion);
            //zooCage.Add(lion2);


            //zooCage.ShowAllAnimals();

            //Console.WriteLine("------------------------");

            //Elephant elephant = new Elephant {Name="Many",AvgLifeTime=30,TeethWeight=40 };
            //Elephant elephant2 = new Elephant {Name="Pumba",AvgLifeTime=30,TeethWeight=20 };

            //ZooCage<Elephant,Grass> zooCage2 = new ZooCage<Elephant,Grass>(grass);
            //zooCage2.Add(elephant);
            //zooCage2.Add(elephant2);

            //zooCage2.ShowAllAnimals();










        }
    }
}
