using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Vehicle
{
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }
    }
}
