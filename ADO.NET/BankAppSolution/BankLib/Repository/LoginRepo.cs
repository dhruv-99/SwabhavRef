using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib;
using System.Data.SqlClient;
using BankLib.Model;

namespace BankLib.Repository
{
   public class LoginRepo
    {
        public bool LoginUser(string name, string password)
        {
            DBTransaction transaction = new DBTransaction();
            string query = "select * from bank_master where name = @name and pass = @pass;";
             transaction.IsValidUser(query, name, password);
            return true;
        }
    }
}
