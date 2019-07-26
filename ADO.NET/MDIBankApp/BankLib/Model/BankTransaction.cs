using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib.Model
{
   public class BankTransaction
    {
        private string _name;
        private double _amount;
        private char _type;
        private DateTime _date;

        public BankTransaction(string name, double amount, char type, DateTime date)
        {
            _name = name;
            _amount = amount;
            _type = type;
            _date = date;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Amount
        {
            get
            {
                return _amount;
            }
        }
        public char Type
        {
            get
            {
                return _type;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

    }
}
