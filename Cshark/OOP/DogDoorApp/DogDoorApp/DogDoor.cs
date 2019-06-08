using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorApp
{
    class DogDoor
    {
        private bool _open;

        public DogDoor()
        {
            this._open = false; 
        }
        public void Open()
        {
            Console.WriteLine("The Dog door opens...");
            _open = true;
        }
        public void Close()
        {
            Console.WriteLine("The Dog door closes...");
            _open = false;
        }
        public bool IsOpen()
        {
            return _open;
        }

    }
}
