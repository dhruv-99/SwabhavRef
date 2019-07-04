using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodApp
{
   public interface IAutomobileFactory
    {
        IAutomobile Make();
    }
}
