using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Animals
{
    internal abstract class Bird:Animal
    {
        public bool HasEgg { get; set; }
        //public int FlySpeed { get; set; }

        //public virtual void Fly()
        //{
        //    Console.WriteLine("Flied away");
        //}
    }
}
