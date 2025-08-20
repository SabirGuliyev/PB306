using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminD { get; set; }
        public int VitaminE { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Ananas kimi"); ;
        }
    }
}
