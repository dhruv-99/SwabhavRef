using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Business
{
    public class Account
    {
        private int _accountno;
        private string _name;
        private double _balance;
        private static int _count;

        static Account()
        {
            _count = 0;
        }
        public Account()
        {
            Console.WriteLine("This is default constructor");
        }
        public Account(int accountno, string name, double balance) 
            {
            _accountno = accountno;
            _name = name;
            _balance = balance;
            _count++;
            
            }
        public  Account(int accountno, string name): this(accountno, name, 500)
        {

        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void withdraw(double amount)
        {
            if (_balance > 500 && (_balance-amount)>=500)
                _balance = _balance - amount;
        }

        public int Accno
        {
            get
            {
                return _accountno;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public static int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
