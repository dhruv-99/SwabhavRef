using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Multiplication : Observer
    {
        public Multiplication(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Multipllication = : " + (20 * subject.GetState()));
        }
    }
}
