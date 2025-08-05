using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample.Models
{
    

     class Product
    {
        string _brand;
        string _model;
        decimal _price;
        decimal _cost;
        decimal _income;
        int _count;
        


        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 0)
                {
                    _brand = value;
                }
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 0)
                {
                    _model = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value > 0)
                {
                    _cost = value;
                }
            }
        }

        //Get only property
        public decimal Income
        {
            get
            {
                return _income;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            private set
            {
                if(value >= 0)
                {
                    value = _count;
                }
            }
        }


        public Product(string brand,string model,decimal price,decimal cost,int count)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

            
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand:{Brand} Model:{Model} Income:{Income} Count:{Count}");
        }

        public void Sale(int count)
        {

            if (Count >=count&& count>0)
            {
                Count-=count;
                    
               _income += (Price - Cost)*count;
                Console.WriteLine("Satish ugurla heyata kecirildi");
            }
            
            else
            {
                Console.WriteLine("Tessufler olsun mehsul movcud deyil");
            }
        }


        public void Refill(int count)
        {
            if (count > 0)
            {
                Count += count;
            }
        }
    }
}
