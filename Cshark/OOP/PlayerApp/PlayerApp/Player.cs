using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    class Player
    {
        private static readonly int DEFAULT_AGE = 18; 
        private int _id;
        private string _name;
        private GenderOptions _gender;
        private int _age;
        public Player(int id, string name, GenderOptions gender, int age)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _age = age;

        }
        public Player(int id, string name) : this(id, name, GenderOptions.MALE, DEFAULT_AGE)
        {

        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public GenderOptions Gender
        {
            get
            {
                return _gender;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }
        public Player WhoIsElder(Player p)
        {
            if (p._age > this._age)
                return p;
            else
                return this;
        }

    }
}
