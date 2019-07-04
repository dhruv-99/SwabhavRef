using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPViolationApp
{
    class FileLogger
    {
        public void Log(string exception)
        {
            Console.WriteLine("File log");
            Console.WriteLine(exception);
        }
    }
}
