using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomobileLib;

namespace SimpleFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            IAutomobile mobile;
            AutomobileFactory factory = AutomobileFactory.GetInstance();
           mobile =  factory.Make(AutoType.AUDI);
            mobile.Start();
            mobile.Stop();
            mobile = factory.Make(AutoType.BMW);
            mobile.Start();
            mobile.Stop();
        }

        private static void Case1()
        {
            //IAutomobile automobile;
            //AutomobileFactory factory = new AutomobileFactory();
            //automobile = factory.Make(AutoType.AUDI);
            //automobile.Start();
            //automobile.Stop();

            //automobile = factory.Make(AutoType.BMW);
            //automobile.Start();
            //automobile.Stop();

            //automobile = factory.Make(AutoType.TESLA);
            //automobile.Start();
            //automobile.Stop();
            //Console.WriteLine(automobile.GetType());
        }
    }
}
