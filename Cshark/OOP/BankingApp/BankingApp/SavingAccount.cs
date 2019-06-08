using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
    class SavingAccount : Account
    {
        public SavingAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance, "Saving")
        {

        }
        public override void Withdraw(double amount)
        {
            if(Balance >= MINIMUM_BALANCE)
            {
                _balance = _balance - amount;
            }
        }
    }
}
