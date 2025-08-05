using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample.Models
{
    internal class Phone:Product
    {
        string _color="black";
        int _ram=1;
        decimal _balance;

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 1)
                {
                    _color = value;
                }
            }
        }
        public int Ram
        {
            get
            {
                return _ram;
            }
            set
            {
                if (value > 0)
                {
                    _ram = value;
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
            }
        }
        public Phone(
            string brand,
            string model, 
            decimal price,
            decimal cost,
            int count,
            int ram,
            string color="black")
            :base(brand,model,price,cost,count)
        {
            
            Ram= ram;
            Color= color;

        }

        public void Call(int seconds)
        {
            decimal cost = seconds * 0.1m;
            if (cost <= Balance)
            {
                Console.WriteLine("Zeng edildi");
                Balance -= cost;
            }
            else
            {
                Console.WriteLine("Kifayet qeder vesait qoqku");
            }
            
        }

        public void Pay(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
            }
        }

    }
}
