using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
    class FileLogger : ILogger
    {
        public void Log(string exception)
        {
            Console.WriteLine("File logger");
            Console.WriteLine(exception);
        }
    }
}
