using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Example_23_ExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;
            string query = "INSERT INTO Categories (CategoryName, Description ) VALUES ('Chemistry', 'Soap')";
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();   
            }
            Console.WriteLine("Insert was successfull");
            Console.ReadLine();
        }
    }
}
