using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib
{
    class Transactionservices
    {
        public void Do_transactions(string query1 , string query2)
        {

            SqlTransaction objTransaction = null;


            using (SqlConnection connection = DatabaseConnection.get_instance())
            {

                connection.Open();
                SqlCommand command = connection.CreateCommand();
                objTransaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = objTransaction;
                try
                {
                    command.CommandText = query1;
                    command.ExecuteNonQuery();
                   command.CommandText = query2;
                    command.ExecuteNonQuery();
                    objTransaction.Commit();
                    Console.WriteLine("inside transaction");
                }

                catch (Exception)
                {
                    Console.WriteLine("inside catch");
                    objTransaction.Rollback();
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

    }
}
