using AbstractClassExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Animals
{
     abstract class Animal:BaseEntity
    {
        public double AvgLifeTime { get; set; }
        public string Gender { get; set; }

     
       
        public virtual void Eat()
        {
            Console.WriteLine("Animal eats grass");
        }

        public abstract void MakeSound();
      
    }
}
