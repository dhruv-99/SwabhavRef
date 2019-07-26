using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "hello user";
            Console.WriteLine(name.SnakeCasing());
        }
    }
}
