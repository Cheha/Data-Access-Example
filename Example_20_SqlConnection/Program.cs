using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_20_SqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data source = .; 
                Initial Catalog = NORTHWND; Integrated Security = SSPI";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();           
        }
    }
}
