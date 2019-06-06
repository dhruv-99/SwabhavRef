using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCalisthenicsViolationApp
{
    class Sorting
    {
        int[] _data;
        
        public Sorting(int[] data)
        {
            _data = data;
        }
        public void AscendOrder()
        {
            int temp;
            for(int i = 0; i < _data.Length; i++)
            {
                for(int j = i+1; j < _data.Length; j++)
                {
                    if(_data[i] > _data[j])
                    {
                        temp = _data[i];
                        _data[i] = _data[j];
                        _data[j] = temp;
                    }
                }
            }
            
        }
        public void DescendOrder()
        {
            int temp;
            for (int i = 0; i < _data.Length; i++)
            {
                for (int j = i + 1; j < _data.Length; j++)
                {
                    if (_data[i] < _data[j])
                    {
                        temp = _data[i];
                        _data[i] = _data[j];
                        _data[j] = temp;
                    }
                }
            }

        }

        public int[] Data
        {
           get
            {
                return _data;
            }
        }
    }
}
