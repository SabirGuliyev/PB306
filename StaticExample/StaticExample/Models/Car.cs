using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample.Models
{
    internal class Car : Vehicle
    {

        public int DoorCount { get; set; }
        public bool IsElectric { get; set; }
        public override void DefineNatureHarmness()
        {
            if (IsElectric)
            {
                Console.WriteLine("Low");
                return;
            }
            Console.WriteLine("High");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{DoorCount} {IsElectric}");
        }
    }
}
