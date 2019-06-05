using System;
using System.Collections.Generic;
using System.Text;

namespace ArgumentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments pressent");
            }
            else
            {
                foreach (string a in args)
                {
                    Console.WriteLine("hello " + a);
                }
            }
        }
    }
}
