using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
     class Bmw : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Start Method of Bmw");
        }
        public void Stop()
        {
            Console.WriteLine("Stop Method of Bmw");
        }
    }
}
