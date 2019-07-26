using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SqlInjectionSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;
                Initial Catalog=AurionPro;Integrated Security=True");
            Console.WriteLine("Enter Department Number : ");
            string deptNumber = Console.ReadLine();

            try
            {
                connection.Open();
                var command = new SqlCommand("select * from DEPT where deptno = @deptNumber"
                    , connection);
                command.Parameters.Add("@deptNumber", System.Data.SqlDbType.VarChar);
                command.Parameters["@deptNumber"].Value = deptNumber;
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetValue(0) + " " +
                        dataReader.GetValue(1) + " " + dataReader.GetValue(2));
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "No record found");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

    }
    }
}
