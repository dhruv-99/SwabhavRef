using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionStackTraceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("End of the main");
        }
        static void M1()
        {
            Console.WriteLine("Inside M1");
            M2();
        }
        static void M2()
        {
            Console.WriteLine("Inside M2");
            M3();
        }
        static void M3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("M3 has an exception");
        }
    }
}
