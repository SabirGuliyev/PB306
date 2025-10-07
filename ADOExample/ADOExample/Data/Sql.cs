using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample.Data
{
    internal class Sql
    {
        private const string ConnectionString= "server=MSI;database=ADOPB306;trusted_connection=true;integrated security=true;";
        private static SqlConnection _connection = new SqlConnection(ConnectionString);
         
                                
        public int ExecuteCommand(string cmd)
        {
            int result = 0;
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(cmd, _connection);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                _connection.Close();
            }
          
            return result;


            //int result = 0;

            //using (SqlConnection conn = new(ConnectionString))
            //{
            //    conn.Open();
            //    SqlCommand command = new SqlCommand(cmd, conn);
            //    result = command.ExecuteNonQuery();
            //}
        }

        public DataTable ExecuteQuery(string query) 
        {
            DataTable table = new DataTable();

            try
            {
               
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                _connection.Close();
            }
           
            return table;

        
        }
    }
}
