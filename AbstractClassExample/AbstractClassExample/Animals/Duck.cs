using AbstractClassExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Animals
{
    internal class Duck : Bird,IFly,ISwim
    {
        public int SwimSpeed { get ; set; }
        public int FlySpeed { get ; set; }

        public void Fly()
        {
            Console.WriteLine("Duck flied away");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Gagk");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swam away");
        }
    }
}
