using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example_29_InMemoryRelationships
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories; SELECT * FROM Products;", connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            // dataSet.Tables
            DataTable categoriesTable = dataSet.Tables[0];
            DataTable productsTable = dataSet.Tables[1];

            DataRelation relation = new DataRelation("ProductCategories",
                categoriesTable.Columns["CategoryID"],
                productsTable.Columns["CategoryID"]);
            dataSet.Relations.Add(relation);
            Console.ReadLine();
        }
    }
}
