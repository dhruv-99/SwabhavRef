using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPublisherLib
{
    public class Account
    {
        private int _id;
        private string _name;
        private double _balance;
        private string _email;
        private long _phoneNumber;



        public Account(int id, string name, double balance, string email, long phoneNummber)
        {
            _id = id;
            _name = name;
            _balance = balance;
            _email = email;
            _phoneNumber = phoneNummber;
        }
        public void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance = _balance - amount;
            }
            
        }
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
        public int ID
        {
            get
            {
                return _id;
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
        public string Email
        {
            get
            {
                return _email;
            }
        } 
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
        }
    }
}
