using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphAbstractionExample
{
    internal class Student:Person
    {
        public string UniName { get; set; }
        public int Grade { get; set; }
        //hide  Method hiding
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {UniName} {Grade}");
        }

        //public override string ToString()
        //{
        //    return UniName;
        //}
    }
}
