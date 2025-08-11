using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Models
{
    internal class Person:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
