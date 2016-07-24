using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_30_ConnectedModeTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString)) { 
                
            }
        }
    }
}
