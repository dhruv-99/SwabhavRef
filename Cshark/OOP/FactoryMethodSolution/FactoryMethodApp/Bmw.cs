using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
    class Bmw : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Bmw start method");
        }
        public void Stop()
        {
            Console.WriteLine("Bmw Stop method");
        }
    }
}
