using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
    public class AudiFactory : IAutomobileFactory
    {
        private static AudiFactory _audi;

        private AudiFactory() { }

        public static AudiFactory GetInstance()
        {
            if (_audi == null)
                _audi = new AudiFactory();
            return _audi;
        }
        public IAutomobile Make()
        {
            return new Audi();
        }
    }
}
