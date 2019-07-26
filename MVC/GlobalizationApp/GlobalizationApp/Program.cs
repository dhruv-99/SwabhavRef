using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GlobalizationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int msg = 400;
            Console.WriteLine(msg);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("Hi-IN");
            Console.WriteLine(msg.ToString());
        }
    }
}
