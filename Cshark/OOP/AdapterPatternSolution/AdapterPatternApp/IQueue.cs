using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternApp
{
    public interface IQueue<T> : IEnumerable<T>
    {
        void Enqueue(T element);
        T Dequeue();
        int Count();
    }
}
