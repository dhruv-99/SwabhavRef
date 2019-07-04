using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton _singleton = new Singleton();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _singleton;
        }
        public void ShowMessage()
        {
            Console.WriteLine(" Method called using singleton instance");
        }
    }
}
