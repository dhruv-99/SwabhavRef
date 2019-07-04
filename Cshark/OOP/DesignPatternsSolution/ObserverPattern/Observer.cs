using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
   public abstract class Observer
    {
        public abstract void Update();
        protected Subject subject;
    }
}
