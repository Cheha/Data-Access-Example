using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_24_ExecuteScalar
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;
            string query = "SELECT Count(CategoryName) FROM Categories";
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                int categoriesCount = (int)command.ExecuteScalar();
                Console.WriteLine("We have {0} categories", categoriesCount);
            }

            Console.ReadLine();
        }
    }
}
