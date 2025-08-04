using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample.Models
{
    

    internal class Product
    {
        public string Brand;
        public string Model;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public int Count;

        public Product(string brand,string model,decimal price,decimal cost,int count)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Cost = cost;
            if (count > 0)
            {
                Count = count;
            }
            
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
                    
                Income += (Price - Cost)*count;
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
