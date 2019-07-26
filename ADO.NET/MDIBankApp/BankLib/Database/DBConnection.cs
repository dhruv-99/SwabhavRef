using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib.Database
{
  public class DBConnection
    {
        private static SqlConnection _connection;

        private DBConnection()
        {

        }

        public static SqlConnection GetConnection()
        {
            //   if (_connection == null)
            //   {
            _connection = new SqlConnection(System.Configuration
                .ConfigurationManager.AppSettings["DatabaseConnection"]);
            //   }
            return _connection;
        }
    }
}
