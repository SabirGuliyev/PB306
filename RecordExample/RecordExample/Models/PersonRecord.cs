using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordExample.Models
{
    //internal record PersonRecord(string Name);

    internal record PersonRecord
    {
        public string Name { get; init; }

        //public PersonRecord(string name)
        //{
        //    Name = name;
        //}
    }
}
