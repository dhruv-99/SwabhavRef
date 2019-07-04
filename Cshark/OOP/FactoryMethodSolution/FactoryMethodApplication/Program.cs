using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethodApp;
using System.Reflection;
using System.Configuration;

namespace FactoryMethodApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1(); 

                IAutomobile UR = CreateInstance<TeslaFactory>().Make();
                UR.Start();
                UR.Stop();
            Console.ReadKey();

        }

        private static void Case1()
        {
            IAutomobile mobile;
            TeslaFactory tesla = TeslaFactory.GetInstance();
            mobile = tesla.Make();
            mobile.Start();
            mobile.Stop();

            BmwFactory bmw = BmwFactory.GetInstance();
            mobile = bmw.Make();
            mobile.Start();
            mobile.Stop();

            AudiFactory audi = AudiFactory.GetInstance();
            mobile = audi.Make();
            mobile.Start();
            mobile.Stop();
        }

        public static I CreateInstance<I>() where I : class
        {
            string assemblyPath = Environment.CurrentDirectory + "\\FactoryMethodApp.dll";
            string str = ConfigurationManager.AppSettings["factory"];
            Assembly assembly;

            assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType("FactoryMethodApp.TeslaFactory");

            var a = type.GetMethod("GetInstance").Invoke(null, null);
            return a as I;
        }
    }
}
