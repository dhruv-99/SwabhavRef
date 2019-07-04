using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class DataService
    {
        private static DataService _container;
        private DataService()
        {
            Console.WriteLine("Service created");
        }
        public void DoSomething()
        {
            Console.WriteLine("Data service by " + this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            if (_container == null)
                _container = new DataService();
            return _container;
        }
    }
}
