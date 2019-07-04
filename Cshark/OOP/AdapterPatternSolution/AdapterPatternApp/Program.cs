using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<string> queue = new QueueAdapter<string>();
            queue.Enqueue("Dhruv");
            queue.Enqueue("Sanal");
            Console.WriteLine(queue.Count());
            queue.Dequeue();
            Console.WriteLine(queue.Count());

            foreach(string element in queue)
            {
                Console.WriteLine( element);
            }
        }
    }
}
