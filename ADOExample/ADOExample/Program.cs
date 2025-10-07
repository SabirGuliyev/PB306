using ADOExample.Data;
using ADOExample.Models;
using ADOExample.Services;
using System.Data;
using System.Data.SqlClient;

namespace ADOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADO.NET Intro

            //string connectionString = "server=MSI;database=ADOPB306;trusted_connection=true;integrated security=true;";

            //SqlConnection conn = new SqlConnection(connectionString);

            //conn.Open();

            //SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Students",conn);

            //DataTable table=new DataTable();

            //query.Fill(table);
            //conn.Close();


            //foreach(DataRow item in table.Rows)
            //{
            //    //Console.WriteLine(item[0]+" " + item[1]+" " + item[2] + " " + item[3]);
            //    Console.WriteLine(item["Id"]+" "+ item["Surname"] +" " + item["Name"]+" "  + item["Age"]);
            //}













            //SqlCommand command = new SqlCommand("INSERT INTO Students VALUES('Test','Testov',30)", conn);



            //int result = command.ExecuteNonQuery();
            //command.CommandText = "DELETE FROM Students WHERE Id=4";
            //command.ExecuteNonQuery();
            //conn.Close();

            //if (result > 0)
            //{
            //    Console.WriteLine("Completed Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Error occured");
            //}


            #endregion


            StudentService service = new();


            List<Student> students=service.GetAll();
            

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }

            //Student student = new Student
            //{
            //    Name = "Elchin",
            //    Surname = "Nuriyev",
            //    Age = 21
            //};
            //service.Add(student);





        }
    }
}
