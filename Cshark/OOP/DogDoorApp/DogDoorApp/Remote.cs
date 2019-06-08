using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorApp
{
    class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor _door)
        {
            this._door = _door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (_door.IsOpen())
            {
                _door.Close();
            }
            _door.Open();
            Thread thread = new Thread(AutoDoorClose);
            thread.Start();
        }
        public void AutoDoorClose()
        {
            
            _door.Close();
            
            
        }
        
       
}
}
    

