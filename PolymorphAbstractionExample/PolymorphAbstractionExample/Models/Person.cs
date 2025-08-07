using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphAbstractionExample
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

        public sealed override string ToString()
        {
            return $"Name:{Name}";
        }
    }
}
