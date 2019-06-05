using System;
using System.Collections.Generic;
using System.Text;

namespace EnumApp
{
  
    class Program
    {
        enum month { Jan, Feb, March, April, May, June, July, August, Sept, October, November, December };
        static void Main(string[] args)
        {
            Console.WriteLine("January is month # "+(int)month.Jan);
        }
    }
}
