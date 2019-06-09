using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineeringCollegeApp.SalariedEmployee;

namespace EngineeringCollegeApp
{
    class Person
    {
        private int _id;
        private string _address;
        private DateTime _dateOfBirth;

        public Person(int id, string address, DateTime dateOfBirth)
        {
            _id = id;
            _address = address;
            _dateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return "ID = "+Id+"\nAddress = "+Address+"\nDate of Birth = "+DateOfBirth+"\nAge = "+Age;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
        }
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _dateOfBirth.Year);
            }
        }
    }
}
