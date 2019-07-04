using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
    class DBLogger : ILogger
    {
        public void Log(String exception)
        {
            Console.WriteLine("Database Logger");
            Console.WriteLine(exception);
        }
    }
}
