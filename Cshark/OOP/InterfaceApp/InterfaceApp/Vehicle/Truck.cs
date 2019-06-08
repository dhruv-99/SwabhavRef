using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Vehicle
{
    class Truck : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}
