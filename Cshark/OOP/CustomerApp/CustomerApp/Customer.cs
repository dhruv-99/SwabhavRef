using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    class Customer
    {
        private static int id;
        private string _firstname;
        private string _lastname;
        private int _id;
        static Customer()
        {
            id = 1001;
        }

        public Customer(String fname, string lname)
        {
            _id = id++;
            _firstname = fname;
            _lastname = lname;
            
        }
        
        public int Id
        {
            get
            {
                return _id;
            }
        }
    }
}
