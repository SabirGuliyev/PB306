using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Zoo
{
    //                                Generic Constraints
    internal class ZooCage<T,U> where T:Animal,new()
                                where U : Food,new()
    {
        public T[] Animals=new T[0];

        public U Food { get; set; }

        public ZooCage(U food)
        {
            Food = food;
        }
        public void ShowAllAnimals()
        {
            foreach (T animal in Animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
        public void Add(T animal)
        {
            Array.Resize(ref Animals, Animals.Length + 1);
            Animals[Animals.Length-1]=animal;
        }
    }
}
