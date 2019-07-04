using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
    public class TeslaFactory : IAutomobileFactory
    {
        private static TeslaFactory _tesla;

        private TeslaFactory() { }
        public static TeslaFactory GetInstance()
        {
            if (_tesla == null)
                _tesla = new TeslaFactory();
            return _tesla;
        }
        public IAutomobile Make()
        {
            return new Tesla(); 
        }

       
    }
}
