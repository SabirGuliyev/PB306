using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Models
{
    internal class Student:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Group Group { get; set; }
        public bool IsQuarrantee { get; set; }
       

    }
}
