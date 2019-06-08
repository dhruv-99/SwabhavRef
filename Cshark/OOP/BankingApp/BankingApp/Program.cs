using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new SavingAccount(101, "Dhruv", 5000.60);
            Account account2 = new CurrentAccount(102, "Akash", 6000.50);
            display(account1);
            account1.Deposit(100);
            display(account1);
            display(account2);
        }
        public static void display(Account account)
        {
            Console.WriteLine("Account Number = " + account.AccountNumber);
            Console.WriteLine("Account Holder = " + account.AccountHolder);
            Console.WriteLine("Account Balance = " + account.Balance);
            Console.WriteLine("Account Type = " + account.AccountType);
        }
    }
}
