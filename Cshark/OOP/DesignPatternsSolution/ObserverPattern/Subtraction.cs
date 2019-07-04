using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Subtraction : Observer
    {
        public Subtraction(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Subtraction = : " + (100 - subject.GetState()));
        }
    }
}
