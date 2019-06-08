using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ContactApp
{
    [Serializable]
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        public Contact(string name, string email, string phoneNumber)
        {
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
        }
       

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
        }


    }
}
