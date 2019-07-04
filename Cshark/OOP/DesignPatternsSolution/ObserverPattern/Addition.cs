using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Addition : Observer
    {
        public Addition(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Addition = : " + (subject.GetState() + subject.GetState()));
        }
    }
}



