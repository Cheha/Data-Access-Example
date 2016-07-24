using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Example_28_SerializingAsXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;
            var selectStatement = "SELECT * FROM Categories";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = new SqlCommand(selectStatement)) {
                    command.Connection = connection;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter.Fill(ds, "Categories");
                    ds.WriteXml("ds.xml"); // Save this DataSet as XML
                    ds.WriteXmlSchema("ds.xsd");
                    ds.Clear();

                    ds.ReadXml("ds.xml");
                    DataTable categories = ds.Tables["Categories"];
                    foreach(DataRow item in categories.Rows)
                    {
                        Console.WriteLine("id: {0},    {1} {2}:",
                            item["CategoryID"], 
                            item["CategoryName"],
                            item["Description"]);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
