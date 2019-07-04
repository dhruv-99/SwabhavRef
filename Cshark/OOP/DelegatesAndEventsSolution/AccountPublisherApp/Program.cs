using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace AccountPublisherApp
{
    class Program
{
    static void Main(string[] args)
    {
            Account account = new Account(1, "Dhruv", 5000,"dhruv@gmail.com", 594488927);
            account.BalanceChangeEvent += SmsNotifier;
            account.BalanceChangeEvent += EmailNotifier;
            account.Deposite(2000);
            account.Withdraw(3000);
    }
    static void SmsNotifier(Account account)
    {
        Console.WriteLine("SMS Notification");
        Console.WriteLine("Current Balance = " + account.Balance);
    }
    static void EmailNotifier(Account account)
    {
        Console.WriteLine("Email Notification");
        Console.WriteLine("Current Balance = " + account.Balance);
    }
}
}
