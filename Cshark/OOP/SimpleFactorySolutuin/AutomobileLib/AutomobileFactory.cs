using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
   public class AutomobileFactory
    {
        private static AutomobileFactory _factory;

        private AutomobileFactory (){}

        public static AutomobileFactory GetInstance()
        {
            if (_factory == null)
                _factory = new AutomobileFactory();
            return _factory;
        }
        public IAutomobile Make(AutoType type)
        {
            if (type == AutoType.AUDI)
                return new Audi();
            if (type == AutoType.BMW)
                return new Bmw();
            if (type == AutoType.TESLA)
                return new Tesla();
            return null;
        }
    }
}
