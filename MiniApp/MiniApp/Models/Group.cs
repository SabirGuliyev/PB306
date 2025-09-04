
using MiniApp.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Models
{
    internal class Group:BaseEntity
    {
        public List<Student> Students { get; set; }= new List<Student>();
        public string No { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public Category Category { get; set; }

        public Group(string no,bool isOnline,Category category)
        {
            No = no;
            if (isOnline) Limit = 15;
            else Limit = 10;

            IsOnline= isOnline;
            Category = category;
        }
    }
}
