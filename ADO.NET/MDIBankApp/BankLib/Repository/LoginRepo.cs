using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib.Database;

namespace BankLib.Repository
{
   public class LoginRepo
    {
        public bool LoginUser(string name, string password)
        {
            DBTransaction transaction = new DBTransaction();
            string query = "select * from bank_master where name = '" + name
                + "' and pass = '" + password + "';";
            transaction.IsValidUser(query);
            return true;
        }
    }
}
