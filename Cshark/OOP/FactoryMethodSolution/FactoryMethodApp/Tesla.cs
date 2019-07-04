using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
    class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla start method");
        }
        public void Stop()
        {
            Console.WriteLine("Tesla Stop method");
        }
    }
}
