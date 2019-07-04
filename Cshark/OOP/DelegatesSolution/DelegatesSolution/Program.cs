using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesSolution
{
    public delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage multicast = PrintHello;
            multicast += PrintGoodBye;
            multicast("Dhruv");
        }

        private static void Case1()
        {
            DPrintMessage m = PrintHello;
            m("Dhruv");
            m = PrintGoodBye;
            m("Dhruv");
            PrintWizard(PrintHello);
        }

        static public void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        static public void PrintGoodBye(string name)
        {
            Console.WriteLine("Good Bye {0}", name);
        }
        static void Foo()
        {
            Console.WriteLine("This is foo");
        }
        static void PrintWizard(DPrintMessage message)
        {
            message("Champ");
        }
    }
}
