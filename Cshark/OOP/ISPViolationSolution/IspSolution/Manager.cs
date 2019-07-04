using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspSolution
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manager starts eating");
        }
        public void StopEat()
        {
            Console.WriteLine("Manager stops eating");
        }
        public void StartWork()
        {
            Console.WriteLine("Manager starts Working");
        }
        public void StopWork()
        {
            Console.WriteLine("Manager stops eating");
        }
    }
}
