using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCalisthenicsSolution
{
    class Sorting
    {
        private int[] _numbers;
        public Sorting(int[] numbers)
        {
            _numbers = numbers; 
        }
        public void Ascending()
        {
            for(int i = 0; i <= _numbers.Length; i++)
            {
                if(_numbers[i] > _numbers[i + 1])
                {
                    int temp = _numbers[i];
                    _numbers[i] = _numbers[i+1];
                    _numbers[i + 1] = temp;
                }

            }
        }
        public void Descending()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (_numbers[i] < _numbers[i + 1])
                {
                    int temp = _numbers[i];
                    _numbers[i] = _numbers[i + 1];
                    _numbers[i + 1] = temp;
                }

            }
        }
        public int[] Numbers
        {
            get
            {
                return _numbers;
            }
        }
    }
}
