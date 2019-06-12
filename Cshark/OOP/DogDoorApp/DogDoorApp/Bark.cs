using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorApp
{
    class Bark
    {
        private string _sound;

        public Bark(String sound)
        {
            _sound = sound;
        }
        public bool Equal(Bark dogBark)
        {
            if (_sound.Equals(dogBark._sound))
            {
                return true;
            }
            return false;
        } 
        public string Sound
        {
            get
            {
                return _sound;
            }
        }

       
    }
}
