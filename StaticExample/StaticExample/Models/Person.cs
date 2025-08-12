using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticExample.Utilities.Extensions;

namespace StaticExample.Models
{
    internal class Person
    {
        //public static int WorkAge { get; set; }
        //public int WorkAge { get; set; }

        public static int _count=0;
        public  int Id { get; set; } = 0;


        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = Helper.Capitalize(value);
                _name = value.Capitalize();
            }
        }//non-static instantiated
        public string Surname { get; set; }

      
        public Person()
        {
            _count++;
            Id=_count;
            
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname}");
        }

      
    }
}
