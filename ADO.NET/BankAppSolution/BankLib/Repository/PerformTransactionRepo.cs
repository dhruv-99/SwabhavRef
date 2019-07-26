using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib
{
    public class PerformTransactionRepo
    {
        DBTransaction transact = new DBTransaction();
        private string query1 = null, query2 = null;
        public bool DoTransaction(string name, string amount, string transactionType)
        {
            if (transactionType.Equals("Withdraw"))
            {
                
                query1 = "insert into bank_transaction values (@Name, @Amount, 'W', GETDATE());";
                query2 = "update bank_master set balance = balance - @Amount where name = @Name;";

            }
            if (transactionType.Equals("Deposit"))
            {
                
                query1 = "insert into bank_transaction values (@Name, @Amount, 'D', GETDATE());";
                query2 = "update bank_master set balance = balance+ @Amount where name = @Name;";
            }
            if (transact.Transaction(query1, query2, name, amount) == true)
            {
                return true;
            }
            return false;
        }
    }
}
