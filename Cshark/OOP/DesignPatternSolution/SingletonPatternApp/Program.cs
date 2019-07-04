using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            // Case2();

            DataService ds1 = DataService.GetInstance();
            DataService ds2 = DataService.GetInstance();
            ds1.DoSomething();
            ds2.DoSomething();
        }

        private static void Case2()
        {
            DataService ds1 = DataService.GetInstance();
            DataService ds2 = DataService.GetInstance();
            ds1.DoSomething();
            ds2.DoSomething();
        }

        //private static void Case1()
        //{
        //   DataService ds1 = new DataService();
        //    DataService ds2 = new DataService();
        //    ds1.DoSomething();
        //    ds2.DoSomething();
        //}
    }
}
