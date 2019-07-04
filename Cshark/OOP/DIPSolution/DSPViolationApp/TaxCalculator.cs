using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPViolationApp
{
    class TaxCalculator
    {
        private Log _logger;

        public TaxCalculator(Log logger)
        {
            _logger = logger;
        }
        public int Calculate(int income, int rate)
        {
            int r=0;
            try
            {
                 r = income / rate;
            }
            catch(Exception e)
            {
                if(_logger == Log.DATABASE)
                {
                    DataBaseLogger db = new DataBaseLogger();
                    db.Log(e.Message);
                }
                else
                {
                    FileLogger fileLogger = new FileLogger();
                    fileLogger.Log(e.Message);
                }
            }
            return r;
        }
    }
}
