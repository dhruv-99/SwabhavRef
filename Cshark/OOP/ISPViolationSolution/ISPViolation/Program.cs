using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Robot robot = new Robot();
            AtTheWorkStation(manager);
            AtTheWorkStation(robot);
            AtTheCafeteria(manager);
            AtTheCafeteria(robot);
        }
        private static void AtTheCafeteria(IWorker worker)
        {
            Console.WriteLine("At the cafeteria");
            worker.StartEat();
            worker.StopEat();
        }
        private static void AtTheWorkStation(IWorker worker)
        {
            Console.WriteLine("The the workstation");
            worker.StartWork();
            worker.StopWork();
        }
    }
}
