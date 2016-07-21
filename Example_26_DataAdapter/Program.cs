using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Example_26_DataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories", connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows) {
                int categoryId = (int)row[0];
                string categoryName = row[1].ToString();
                string description = row[2].ToString();
                Console.WriteLine("{0}, {1}, {2}", categoryId, categoryName, description);
            }
            Console.ReadLine();
        }
    }
}
