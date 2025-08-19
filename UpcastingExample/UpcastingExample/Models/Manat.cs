using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExample.Models
{
    internal class Manat
    {
        public decimal AZN { get; set; }
        public Manat(decimal azn)
        {
            AZN = azn;
        }





        public static bool operator >(Manat manat, Manat manat2)
        {
            return manat.AZN > manat2.AZN;
        }
      
        public static bool operator <(Manat manat, Manat manat2)
        {
            return manat.AZN < manat2.AZN;
        }
        public static Manat operator +(Manat x,Manat y)
        {
            x.AZN += y.AZN;
            return x;
        }




        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.USD * 1.7m);
        }






        public static implicit operator Manat(decimal value)
        {
            return new Manat(value);
        }










        //public static explicit operator Manat(Dollar dollar)
        //{
        //    return new Manat(dollar.USD * 1.7m);
        //}
    }
}
