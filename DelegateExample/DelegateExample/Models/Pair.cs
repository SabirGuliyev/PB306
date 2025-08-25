using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample.Models
{
    internal class Pair<T, U>
    {
        public T Key { get; set; }
        public U Value { get; set; }
        public Pair<T, U>[] Pairs  = [];

        public U this[T key]
        {
            get
            {
                foreach (var pair in Pairs)
                {
                    if (pair.Key.Equals(key))
                    {
                        return pair.Value;
                    }
                }
                return default;

            }
            set {
                foreach (var pair in Pairs)
                {
                    if (pair.Key.Equals(key))
                    {
                       pair.Value=value;
                    }
                }

            }
        }

        public void Add(Pair<T,U> pair)
        {
            foreach (var item in Pairs)
            {
                if (item.Key.Equals(pair.Key))
                {
                    Console.WriteLine("Key Already exist");
                    return;
                }
            }
            Array.Resize(ref Pairs, Pairs.Length + 1);
            Pairs[Pairs.Length-1] = pair;
        }


    }
}
