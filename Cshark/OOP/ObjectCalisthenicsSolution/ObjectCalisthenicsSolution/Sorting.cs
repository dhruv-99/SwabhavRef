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
            int i = 1;
            while (i < _numbers.Length - 1)
            {
                if (_numbers[i] > _numbers[i + 1])
                {
                    int temp = _numbers[i];
                    _numbers[i] = _numbers[i] + 1;
                    _numbers[i + 1] = temp;
                    i = - 1;
                }
                i++;
            }
        }
        //public void Descending()
        //{
        //    int i = 1;
        //    while (i < _numbers.Length - 1)
        //    {
        //        if (_numbers[i] < _numbers[i + 1])
        //        {
        //            int temp = _numbers[i];
        //            _numbers[i] = _numbers[i] + 1;
        //            _numbers[i + 1] = temp;
        //            i = -1;
        //        }
        //        i++;
        //    }
        //}
        public int[] Numbers
        {
            get
            {
                return _numbers;
            }
        }
    }
}
