using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntParsingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "1024";
            int result1 = Convert.ToInt32(value);
            Console.WriteLine(result1);
            int result2 = int.Parse(value);
            Console.WriteLine(result2);
            int _tryParseValue;
            bool result3 = int.TryParse(value, out _tryParseValue);
            Console.WriteLine(result3 + " " + _tryParseValue);
        }
    }
}
