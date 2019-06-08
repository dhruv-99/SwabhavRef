using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance, "Current")
        {

        }
        public override void Withdraw(double amount)
        {
            if(_balance >= -MINIMUM_BALANCE)
            {
                _balance = _balance - amount;
            }
        }
    }
}
