using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.Liskov
{
    internal class Eagle:Bird
    {
        public int Age { get; set; }

        public override void Eat()
        {
       
                Console.WriteLine("Meat");
            
        }
    }
}
