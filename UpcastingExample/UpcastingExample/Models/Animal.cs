using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExample.Models
{
    internal abstract class Animal
    {
        public double AvgLifeTime { get; set; }
        public string Gender { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Grass");
        }
    }
}
