using MiniApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Repositories
{
    internal class Repository<T> where T : BaseEntity
    {

        public void Serialize(string path,List<T> items)
        {
            string json=JsonConvert.SerializeObject(items);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }

        }
        public List<T> Deserialize(string path) 
        {
            string result = null;

            using (StreamReader sr = new(path))
            {
                result = sr.ReadToEnd();
            }



            List<T> items = null;
            if (string.IsNullOrEmpty(result))
            {
                items = new List<T>();
            }
            else
            {
                items = JsonConvert.DeserializeObject<List<T>>(result);
            }
            return items;

        }
    }
}
