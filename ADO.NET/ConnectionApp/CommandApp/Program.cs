using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;
            Initial Catalog=AurionPro;Integrated Security=True");
            try
            {
                connection.Open();
                var command = new SqlCommand("select * from EMP;", connection);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetValue(1));
                    Console.WriteLine(dataReader["ENAME"] + " " + dataReader["SAL"]);
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
