using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Zoo
{
    internal class Lion:Animal
    {
        public bool IsPrime { get; set; }
        public void Roar()
        {
            Console.WriteLine("Lion roars");
        }
    }
}
