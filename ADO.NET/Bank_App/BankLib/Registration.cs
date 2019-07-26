using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankLib
{
    public class Registration
    {
        public void Registercustomer()
        {
            Transactionservices transactions = new Transactionservices();
            string query1 = "insert into bank_master values('jass','akash123',10000)";
            string query2 = "insert into bank_transaction values('jass', 10000, 'D', GETDATE())";
            transactions.Do_transactions(query1 , query2);

        }
    }
}
