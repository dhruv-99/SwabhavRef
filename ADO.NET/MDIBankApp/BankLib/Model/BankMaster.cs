using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib.Model
{
   public class BankMaster
    {
        private static string _name;
        private string _password;
        private double _balance;

        public BankMaster(string name, string password, double balance)
        {
            _name = name;
            _password = password;
            _balance = balance;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
