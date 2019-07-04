using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    class Audi : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Start Method of Audi");
        }
        public void Stop()
        {
            Console.WriteLine("Stop Method of Audi");
        }
    }
}
