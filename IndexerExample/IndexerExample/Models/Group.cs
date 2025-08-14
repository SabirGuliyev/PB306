using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample.Models
{
    internal class Group
    {
        public Student[] Students { get; set; }
        public string Name { get; set; }
                                 
        public Student this[string fin]
        {
            get
            {                   
              foreach (Student student in Students)
                {
                    if (student.FinCode == fin)
                    {
                        return student;
                    }
                }
                return null;
            }
        }
     
    }
}
