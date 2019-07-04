using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Robot robot = new Robot();
            AtTheCafeteria(manager);
            AtTheWorkStation(manager);
            AtTheWorkStation(robot);
        }

        private static void AtTheCafeteria(IEat worker)
        {
            Console.WriteLine("At the cafeteria");
            worker.StartEat();
            worker.StopEat();
        }
        private static void AtTheWorkStation(IWork worker)
        {
            Console.WriteLine("At the workstation");
            worker.StartWork();
            worker.StopWork();
        }
    }
}
