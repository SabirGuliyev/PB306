using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.DIP
{
    internal class Knife:ICut
    {
        public Knife()
        {
            throw new Exception("Knife is broken");
        }
        public void Cut()
        {
            Console.WriteLine("Item was cut");
        }
    }
}
