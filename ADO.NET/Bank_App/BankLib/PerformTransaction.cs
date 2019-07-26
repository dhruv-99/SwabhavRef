using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class PerformTransaction
    {
        string query1, query2;
       
      public  void Transaction(string task , string name , string amount)
        {
            if(task.Equals("deposite"))
            {
                Transactionservices transactions = new Transactionservices();
                query1 = "update  Bank_master set balance = balance - " + amount + " where name =" + name + ";";
                query2 = "insert into Bank_transaction values("+name+","+amount+",'W',GETDATE());";
                transactions.Do_transactions(query1, query2);
            }
            else
            {

            }
        }
    }
}
