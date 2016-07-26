using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_21_SqlCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data source = ALEX-PC\SQLEXPRESS;
                Initial Catalog = NORTHWND; Integrated Security = SSPI";
            string query = "SELECT * FROM Categories";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int categoryId = (int)reader[0];
                string categoryName = reader[1].ToString();
                string description = reader[2].ToString();
                Console.WriteLine("{0}, {1}, {2}", categoryId, categoryName, description);
            }
            connection.Close();
            Console.ReadLine();
        }
    }
}
