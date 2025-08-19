using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExample.Models
{
    internal class Dog:Animal
    {
        public string Name { get; set; }
        public void PlayWithHuman()
        {
            Console.WriteLine("Plays");
        }
    }
}
