using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.DIP
{
    internal class Pizza
    {
        public int Size { get; set; }

        public ICut Instrument { get; set; }
        public Pizza(ICut instrument)
        {

            Instrument = instrument;

        }

        public void Sell()
        {
            Instrument.Cut();
            Console.WriteLine("Ugurla satildi");
        }
    }
}
