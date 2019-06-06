using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingApp
{
    class Game
    {
        private int _randomnumber;

        public void RandomGenerator()
        {
             _randomnumber = new Random().Next(100); 

        }
        public int GuessNum(int userguess)
        {
            if(userguess < _randomnumber)
            {
                return -1;
            }
            if(userguess > _randomnumber)
            {
                return 1;
            }
                return 0;   

        }
    }
}
