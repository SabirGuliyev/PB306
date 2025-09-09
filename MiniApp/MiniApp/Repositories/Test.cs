using MiniApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Repositories
{
    internal class Test<T> : IRepository<T>
        where T:BaseEntity
    {
        public List<T> Deserialize(string path)
        {
            return new List<T>();
        }

        public void Serialize(string path, List<T> items)
        {
            Console.WriteLine("Okay");
        }
    }
}
