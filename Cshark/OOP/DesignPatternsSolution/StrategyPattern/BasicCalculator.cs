using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class BasicCalculator 
    {
        private IMathOperation _mathOperation;

        public BasicCalculator(IMathOperation _mathOperation)
        {
            this._mathOperation = _mathOperation;
        }
        public int GetCalculation(int num1, int num2)
        {
            return _mathOperation.PerformOperation(num1, num2);
        }
    }
}
