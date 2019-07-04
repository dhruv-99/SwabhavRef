using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Start Method of Tesla");
        }
        public void Stop()
        {
            Console.WriteLine("Stop Method of Tesla");
        }
    }
}
