using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(Type);
        }
    }
}
