using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_22_AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;
            string query = "SELECT * FROM Categories";
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection)) {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read())
                    {
                        int categoryId = (int)reader[0];
                        string categoryName = reader[1].ToString();
                        string description = reader[2].ToString();
                        Console.WriteLine("{0}, {1}, {2}", categoryId, categoryName, description);
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
