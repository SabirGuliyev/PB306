

namespace StaticExample.Models
{
    internal abstract class Vehicle
    {
        //protected Vehicle(string name,int num)
        //{
        //    FactoryName = name.Capitalize();
        //    num.Capita
        //}
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public double DriveTime { get; set; }
        public double DrivePath { get; set; }

        public double AverageSpeed()
        {

            return DrivePath/DriveTime;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {AverageSpeed()}");
        }
        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }

        public abstract void DefineNatureHarmness();
    }
}
