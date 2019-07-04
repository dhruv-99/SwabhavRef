using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace BankApplication
{
    class AccountProxy : Account
    {
        public AccountProxy(int id, string name, double balance, string email, long phoneNummber) 
            : base(id, name, balance, email, phoneNummber)
        {
               
        }

        public void Withdraw(int amount)
        {
            Console.WriteLine("Balance = " + base.Balance);
            Console.WriteLine(DateTime.Now);
            base.Withdraw(amount);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Balance = " + base.Balance);
        }

        public void Deposite(int amount)
        {
            Console.WriteLine("Balance = " + base.Balance);
            Console.WriteLine(DateTime.Now);
            base.Deposit(amount);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Balance = " + base.Balance);
        }
    }
}
