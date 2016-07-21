using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_27_UpdateDataUsingDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Nordwind"].ConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories", connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            //foreach (DataRow row in dataSet.Tables[0].Rows)
            //{
            //    // Delete Row
            //    if ((int)row[0] == 10) {
            //        dataSet.Tables[0].Rows.Remove(row);
            //        dataSet.Tables[0].AcceptChanges();
            //        adapter.Update(dataSet);
            //        break;
            //    }
            //}

            
            // Insert row
            DataRow newCategory = dataSet.Tables[0].NewRow();
            newCategory["CategoryName"] = "Suplies";
            newCategory["Description"] = "Some stuff";
            dataSet.Tables[0].Rows.Add(newCategory);
            dataSet.Tables[0].AcceptChanges();
            adapter.Update(dataSet);
            
            Console.WriteLine("Categories sucessfully updated");
            Console.ReadLine();
        }
    }
}
