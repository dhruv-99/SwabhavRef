using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternApp
{
    class QueueAdapter<T> : IQueue<T> , IEnumerable <T>
    {
        LinkedList<T> _queue = new LinkedList<T>();

        public void Enqueue(T element)
        {
            _queue.AddLast(element);
        }
        public T Dequeue()
        {
            T element = _queue.First();
            _queue.RemoveFirst();
            return element;
        }
        public int Count()
        {
            return _queue.Count;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
