using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.OCP
{
    internal class MushedPotato : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Mushed potato is ready");
        }
    }
}
