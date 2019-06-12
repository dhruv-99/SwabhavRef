using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorApp
{
    class DogDoor
    {
        private bool _open;
        private ArrayList _allowedBarks;

        public DogDoor()
        {
            _allowedBarks = new ArrayList();
            this._open = false; 
        }
        public void Open()
        {
            Console.WriteLine("The Dog door opens...");
            _open = true;
            Thread thread = new Thread(AutoDoorClose);
            thread.Start();
        }
        public void Close()
        {

            Console.WriteLine("The Dog door closes...");
            _open = false;
        }
        public void AutoDoorClose()
        {
            
            Close();
        }
        public bool IsOpen()
        {
            return _open;
        }
        public void AddAllowedBarks(Bark bark)
        {
            _allowedBarks.Add(bark);
        }
        public ArrayList AllowedBarks
        {
            get
            {
                return _allowedBarks;
            }
        }
    }
}
