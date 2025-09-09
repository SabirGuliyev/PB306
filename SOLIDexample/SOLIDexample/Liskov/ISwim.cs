using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.Liskov
{
    internal interface ISwim
    {
        public int SweemSpeed { get; set; }

        void Swim();
    }
}
