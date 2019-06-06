using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorLib;

namespace CalculatorApp
{
    class Calculation 
    {
        private int _number1;
        private int _number2;
        public Calculation()
        {
            _number1 = 0;
            _number2 = 0;
        }
        public int Add()
        {
            int addResult = Calculator.Add(_number1, _number2);
            return addResult; 
        }
        public int Number1
        {
            get
            {
                return _number1;
            }
            set
            {
                _number1 = value;
            }
        }
        public int Number2
        {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
            }
        }
    }
}
