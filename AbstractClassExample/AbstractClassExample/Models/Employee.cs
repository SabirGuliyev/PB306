using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Models
{
    internal class Employee:Person
    {
        public string Company { get; set; }
        public decimal SalaryPerHour { get; set; }
        public int Hour { get; set; }
        public int Experience { get; set; }

        public virtual decimal CalculateSalary()
        {
            decimal salary = Hour * SalaryPerHour;
            return salary;
        }
    }
}
