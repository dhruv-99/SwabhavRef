using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib
{
    public class RegistrationRepo
    {
        public bool RegisterUser(string name, string password,string confirmPassword, string amount)
        {
            DBTransaction register = new DBTransaction();
            string query1 = "insert into bank_master values('" + name + "','"
                + password + "'," + amount + ")";

            string query2 = "insert into bank_transaction values('" + name + "', "
                + amount + ", 'D', GETDATE())";
            if (register.Transaction(query1, query2,name,password) == true)
                return true;
            return false;
        }
    }
}
