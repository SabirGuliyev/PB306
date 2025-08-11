using AbstractClassExample.Animals;
using AbstractClassExample.Interfaces;
using AbstractClassExample.Vehicles;


namespace AbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog
            {
                AvgLifeTime=15,
                Gender="male",
                Name="Maximus Prime"
            };


            Cow cow = new Cow
            {
                AvgLifeTime = 5,
                Gender = "female",
                Productivity = 5.5
            };



            Penguin penguin = new Penguin
            {
                AvgLifeTime = 7,
                IsSingle = true,
                Gender = "male",
                HasEgg = false,
            };
            Eagle eagle = new Eagle
            {
                AvgLifeTime = 20,
                FlySpeed = 150,
                ClawPower = 900,
                Gender = "male",
                HasEgg = false,
            };

            Plane plane = new Plane();
            Duck duck = new Duck();



            IFly[] flyables = { plane, duck, eagle };
            ISwim[] swimables = { duck, penguin };

            for (int i = 0; i < flyables.Length; i++)
            {
                flyables[i].Fly();
            }


            //Animal[] animals = { penguin, eagle, cow, dog };

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    animals[i]
            //}


            //dog.MakeSound();

            //cow.MakeSound();
            //BaseEntity baseEntity = new BaseEntity
            //{
            //    Id = 1
            //};
            //Animal animal = new Animal
            //{
            //    AvgLifeTime = 10,
            //    Gender = "male"
            //};







            eagle.Fly();


          



        }
    }
}
