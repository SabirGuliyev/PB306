using MiniApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Repositories
{
    internal interface IRepository<T>where T:BaseEntity
    {
        void Serialize(string path, List<T> items);
        List<T> Deserialize(string path);
    }
}
