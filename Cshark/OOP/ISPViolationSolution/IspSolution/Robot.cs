using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspSolution
{
    class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robot starts working");
        }
        public void StopWork()
        {
            Console.WriteLine("Robot stops working");
        }
    }
}
