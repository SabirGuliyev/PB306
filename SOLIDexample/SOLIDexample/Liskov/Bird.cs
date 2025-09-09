using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.Liskov
{
    internal abstract class Bird
    {
        public bool HasEgg { get; set; }
      
        public virtual void Eat()
        {
            Console.WriteLine("Grass");
        }
    }
}
