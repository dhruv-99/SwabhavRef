using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolation
{
    interface IWorker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
