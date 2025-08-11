using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Animals
{
    internal class Dog:Animal
    {
        public string Name { get; set; }

       
        public void Guard()
        {
            Console.WriteLine("Guards");
        }

   
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
