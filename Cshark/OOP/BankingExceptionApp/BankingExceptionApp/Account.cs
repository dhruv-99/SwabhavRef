using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingExceptionApp;

namespace BankingApp
{
    public class Account
    {
        private readonly int MINIMUM_BALANCE;
        private readonly int _accountNumber;
        private readonly string _accountHolder;
        protected double _balance;
        private readonly string _accountType;

        public Account(int accountNumber, string accountHolder, double balance, string accountType)
        {
            MINIMUM_BALANCE = 500;
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = balance;
            _accountType = accountType;
        }
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
        public void Withdraw(double amount)
        {
            double _amount = amount;
            if ((Balance - amount) < MINIMUM_BALANCE)
            {
                throw new InsufficientFundException(this, _amount);
            }
            else
                _balance = _balance - amount;
        }

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
