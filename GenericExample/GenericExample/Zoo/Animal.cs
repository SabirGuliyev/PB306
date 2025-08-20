using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Zoo
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public int AvgLifeTime { get; set; }

    
        public virtual void Eat() {

            Console.WriteLine("Grass");
        }

       
    }
}
