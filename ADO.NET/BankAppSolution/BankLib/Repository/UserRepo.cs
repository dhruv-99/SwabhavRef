using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib.Repository
{
    public class UserRepo
    {
        BankLib.Model.BankMaster tMaster;
        public BankLib.Model.BankMaster GetUserDetails(string name)
        {
            string query = "select * from bank_master where name = '"+name +"';";
            DBTransaction transaction = new DBTransaction();
            tMaster = transaction.GetDetails(query);
            return tMaster;
        }
    }
}
