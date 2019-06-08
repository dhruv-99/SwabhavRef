﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            
            Console.WriteLine("Fido wants to go outside ");
            remote.PressButton();
            Thread.Sleep(5000);

            Console.WriteLine("Fido has gone outside ");
            Console.WriteLine("Fido is all done ");

            Console.WriteLine("But he's stuck outside");
            Console.WriteLine("Fido  starts barking.. So Gina grabs the remote control.. ");
            remote.PressButton();
            Console.WriteLine("Fido's back inside..");
        }
    }
}
