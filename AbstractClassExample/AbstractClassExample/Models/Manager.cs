using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.Models
{
    internal class Manager:Employee
    {
        public decimal Bonus { get; set; }
        public override decimal CalculateSalary()
        {
           decimal firstSalary = base.CalculateSalary();
            decimal bonusSalary = firstSalary + (firstSalary * Bonus);
            return bonusSalary;
        }
    }
}
