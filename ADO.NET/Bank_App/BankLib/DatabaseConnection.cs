using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib
{
  public  class DatabaseConnection
    {
        private static SqlConnection _connection;

        private DatabaseConnection()
        {

        }
       
          public static SqlConnection get_instance()
        {
            if(_connection == null)
            {

                _connection = new SqlConnection(@"Data Source =.\sqlexpress;
             Initial Catalog = AurionPro;
             Integrated Security = True");
            }
           
            return _connection;
        }
    }
}
