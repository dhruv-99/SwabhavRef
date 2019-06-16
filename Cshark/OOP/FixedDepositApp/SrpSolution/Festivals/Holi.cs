using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrpSolution.Festivals
{
    class Holi : IRateDeciider
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}
