using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Animals
{
    internal class Cow:Animal
    {
        public double Productivity { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Mooooooooooo");
        }

        public void ProduceMilk()
        {

            Console.WriteLine("Cow produced milk");
        }
    }
}
