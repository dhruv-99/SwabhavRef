using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
    class TaxCalculator
    {
        ILogger _logger;

        public TaxCalculator(ILogger logger)
        {
            _logger = logger;
        }
        public int Calculate(int income, int rate)
        {
            int r = 0;
            try
            {
                r = income / rate;
            }
            catch(Exception e)
            {
                _logger.Log(e.Message);
            }
            return r;
        }
    }
}
