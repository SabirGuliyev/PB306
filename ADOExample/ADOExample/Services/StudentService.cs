using ADOExample.Data;
using ADOExample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample.Services
{
    internal class StudentService
    {
        private static Sql _sql=new();

        public void Add(Student student)
        {
           int result= _sql.ExecuteCommand($"INSERT INTO Students VALUES('{student.Name}','{student.Surname}',{student.Age})");
            if (result > 0)
            {
                Console.WriteLine("Completed Successfully");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
        }

        public List<Student> GetAll()
        {
            DataTable table = _sql.ExecuteQuery("SELECT * FROM Students");

            List<Student> students = new();


            foreach (DataRow item in table.Rows) 
            {
                students.Add(new Student
                {
                    Id = (int)item["Id"],
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Age = (int)item["Age"]
                });
            }

            return students;
        }
    }
}
