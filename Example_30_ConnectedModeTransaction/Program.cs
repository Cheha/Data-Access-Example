using System;
using System.Configuration;
using System.Collections.Generic;
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
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = @"INSERT INTO Region VALUES(5, 'Central')";
                    command.ExecuteNonQuery();
                    command.CommandText = @"INSERT INTO Region VALUES(6, 'Central')";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    Console.WriteLine("OK");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx) {
                        Console.WriteLine(rollbackEx.Message);
                    }
                }
            }
        }
    }
}
