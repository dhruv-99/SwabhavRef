using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib.Database;

namespace BankLib.Repository
{
  public class PerformTransactionRepo
    {
        DBTransaction transact = new DBTransaction();
        private string query1 = null, query2 = null;
        public bool DoTransaction(string name, double amount, string transactionType)
        {
            if (transactionType.Equals("Withdraw"))
            {

                query1 = "update bank_master set balance = balance - "
                    + amount + " where name = '" + name + "';";
                query2 = "insert into bank_transaction values ('"
                    + name + "', " + amount + ", 'W', GETDATE());";

            }
            if (transactionType.Equals("Deposit"))
            {
                query1 = "update bank_master set balance = balance + "
                    + amount + " where name = '" + name + "';";
                query2 = "insert into bank_transaction values ('"
                    + name + "', " + amount + ", 'D', GETDATE());";
            }
            if (transact.Transaction(query1, query2) == true)
            {
                return true;
            }
            return false;
        }
    }
}
