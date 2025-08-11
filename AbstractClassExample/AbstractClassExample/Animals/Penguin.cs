using AbstractClassExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Animals
{
    internal class Penguin : Bird,ISwim
    {

        public bool IsSingle { get; set; }
        public int SwimSpeed { get ; set ; }

        public override void MakeSound()
        {
            Console.WriteLine("Kowalski");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin swam away");
        }
    }
}
