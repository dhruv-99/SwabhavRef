using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
    class Audi : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Audi start method");
        }
        public void Stop()
        {
            Console.WriteLine("Audi Stop method");
        }
    }
}
