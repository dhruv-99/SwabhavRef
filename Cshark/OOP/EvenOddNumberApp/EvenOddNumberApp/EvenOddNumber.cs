using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EvenOddNumberApp
{
    class EvenOddNumber
    {
        
       public ArrayList even()
        {
            ArrayList list = new ArrayList();
            for (int i =0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    list.Add(i);
            }
            return list;
        }
        public ArrayList odd()
        {
            ArrayList list = new ArrayList();
            for (int i=0; i <= 100; i++)
            {
                if (i % 2 != 0)
                    list.Add(i);
            }
            return list;
        }
    }
}
