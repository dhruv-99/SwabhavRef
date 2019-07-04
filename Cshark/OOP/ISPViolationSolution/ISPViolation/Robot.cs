using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolation
{
    class Robot : IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Robot starts working");
        }
        public void StopWork()
        {
            Console.WriteLine("Robot stops working");
        }
        public void StartEat()
        {
            throw new NotImplementedException(); 
        }
        public void StopEat()
        {
            throw new NotImplementedException();
        }
    }
}
