using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Models
{
    internal class Group
    {
        Student[] _students=new Student[0];

        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }

        public string Name { get; set; }
        public int GroupLimit { get; set; }


      
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length-1] = student;

        }

        public void ShowStudents()
        {
            Students[0]._name
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].PrintInfo();
            }
        }
    }
}
