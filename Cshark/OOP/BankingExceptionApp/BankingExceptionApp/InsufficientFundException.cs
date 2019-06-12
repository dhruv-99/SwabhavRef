using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp;
namespace BankingExceptionApp
{
    class InsufficientFundException : Exception
    {
        private readonly Account _account;
        private readonly double _amount;
        public InsufficientFundException(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }
        public override string Message
        {
            get
            {
                return "Sorry " + _account.AccountHolder + " you dont have sufficient balance..\n"
                    + "Total balance = " + _account.Balance + "\nYou tried to remove " + _amount;
            }
        }
    }
}
