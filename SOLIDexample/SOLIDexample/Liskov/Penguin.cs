using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.Liskov
{
    internal class Penguin : Bird,ISwim
    {
        public int SweemSpeed { get ; set ; }
      

       

        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
