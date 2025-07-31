

namespace ClassObjectExample.Models
{
    internal class Teacher:Person
    {
        public string Profession;
        public int Experience;
        public decimal Salary;

        public Teacher(string name):base(name)
        {
            
        }


    }
}
