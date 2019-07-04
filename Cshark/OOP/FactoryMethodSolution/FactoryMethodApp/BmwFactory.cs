using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
    public class BmwFactory
    {
        private static BmwFactory _bmw;

        private BmwFactory() { }

        public static BmwFactory GetInstance()
        {
            if (_bmw == null)
                _bmw = new BmwFactory();
            return _bmw;
        }
        public IAutomobile Make()
        {
            return new Bmw();
        }
    }
}
