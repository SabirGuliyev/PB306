using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample.Models
{
    internal struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }



        public PointStruct()
        {
            X = default;
            Y = default;
        }
    }
}
