using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace ApplicationConfigurationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string stringValue1 = ConfigurationManager.AppSettings["key1"];
            string stringValue2 = ConfigurationManager.AppSettings["key2"];
            string stringValue3 = ConfigurationManager.AppSettings["key3"];
            Console.WriteLine("Value 1 = " + stringValue1 + "\nValue 2 = " + stringValue2 + "\nvalue 3 = " + stringValue3);
        }
    }
}
