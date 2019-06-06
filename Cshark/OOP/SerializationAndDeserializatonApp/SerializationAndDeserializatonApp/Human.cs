using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
   [Serializable]
    class Human
    {
        private static readonly float WEIGHT_DECREEMENT = 0.02f;
        private static readonly float WEIGHT_INCREEMENT = 0.05f;
        private static readonly float HEIGHT_INCREEMENT = 0.01f;
        private string _name;
        private float _height, _weight;
        private readonly int _age;
        private string _gender;

        public Human(string name, float height, float weight) : this(name, height, weight, 18)
        {

        }

        public Human(string name, float height, float weight, int age)
        {
            _name = name;
            _height = height;
            _weight = weight;
            _age = age;
            _gender = "male";
        }
        public void Workout()
        {
            _weight = _weight - (_weight * WEIGHT_DECREEMENT);
        }

        public void Eat()
        {
            _weight = _weight + (_weight * WEIGHT_INCREEMENT);
            _height = _height + (_height * HEIGHT_INCREEMENT);
        }

        public string Name
        {
            get
            {
                return _name;
            }

        }
        public float Weight
        {
            get
            {
                return _weight;
            }

        }

        public float Height
        {
            get
            {
                return _height;
            }

        }
        public float Age
        {
            get
            {
                return _age;
            }

        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                value = value.ToLower();
                if (value == "female")
                    _gender = value;
                      
            }
        }
    }
}
