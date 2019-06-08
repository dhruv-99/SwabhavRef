using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
   public abstract class Account
    {
        public readonly int MINIMUM_BALANCE = 1000;
        private int _accountNumber;
        private string _accountHolder;
        public double _balance;
        private string _accountType;

        public Account(int accountNumber, string accountHolder, double balance, string accountType)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = balance;
            _accountType = accountType;
        }
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
        public abstract void Withdraw(double amount);

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        public string AccountHolder
        {
            get
            {
                return _accountHolder;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            
        }
        public string AccountType
        {
            get
            {
                return _accountType;
            }
        }
        
    }
}
