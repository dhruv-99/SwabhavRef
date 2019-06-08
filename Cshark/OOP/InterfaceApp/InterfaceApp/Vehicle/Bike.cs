using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Vehicle
{
    class Bike : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bus is moving...");
        }
    }
}
