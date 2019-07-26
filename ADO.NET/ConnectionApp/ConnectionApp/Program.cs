using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AurionPro;Integrated Security=True");
            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
                Console.WriteLine(connection.Database);
                Console.WriteLine(connection.ServerVersion);
                Console.WriteLine(connection.ConnectionTimeout);
                Console.WriteLine(connection.DataSource);
                Console.WriteLine(connection.FireInfoMessageEventOnUserErrors);

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
