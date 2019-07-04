using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern;

namespace FacadePattern
{
    class BasicCalculator
    {
        private IMathOperation _addition;
        private IMathOperation _subtraction;
        private IMathOperation _multiply;
        private IMathOperation _division;

        public BasicCalculator()
        {
            _addition = new Addition();
            _subtraction = new Subtraction();
            _multiply = new Multiply();
            _division = new Division();
        }
        public int AdditionOperation(int num1, int num2)
        {
            return _addition.PerformOperation(num1, num2);
        }
        public int SubtractionOperation(int num1, int num2)
        {
            return _subtraction.PerformOperation(num1, num2);
        }
        public int MultiplicationOperation(int num1, int num2)
        {
            return _multiply.PerformOperation(num1, num2);
        }
        public int DivisionOperation(int num1, int num2)
        {
            return _division.PerformOperation(num1, num2);
        }
    }
}
