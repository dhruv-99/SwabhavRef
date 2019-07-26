using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib
{
   public class DBTransaction
    {
        public bool Transaction(string query1, string query2, string name, string amount)
        {
            SqlTransaction transaction = null;
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlCommand command1 = connection.CreateCommand();


                transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;

                command1.Connection = connection;
                command1.Transaction = transaction;

                try
                {
                    command.CommandText = query1;
                    command.Parameters.Add("@Name",System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@Amount", System.Data.SqlDbType.Float);
                    command.Parameters["@Name"].Value = name;
                    command.Parameters["@Amount"].Value = amount;



                    command1.CommandText = query2;
                    command1.Parameters.Add("@Name", System.Data.SqlDbType.VarChar);
                    command1.Parameters.Add("@Amount", System.Data.SqlDbType.Float);
                    command1.Parameters["@Name"].Value = name;
                    command1.Parameters["@Amount"].Value = amount;


                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    connection.Close();
                    return false;
                }
            }
        }
        public bool IsValidUser(string query, string name, string password)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                try
                {
                    command.CommandText = query;
                    var reader =  command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            BankLib.Model.BankMaster bankMaster = new Model.BankMaster(Convert.ToString(reader.GetValue(0)),Convert.ToString(reader.GetValue(1)),Convert.ToDouble(reader.GetValue(2)));
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public BankLib.Model.BankMaster GetDetails(string query)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                try
                {
                    command.CommandText = query;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            BankLib.Model.BankMaster bankMaster = new Model.BankMaster(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1)), Convert.ToDouble(reader.GetValue(2)));
                            return bankMaster;
                        }
                    }
                    return null;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

    }
}
