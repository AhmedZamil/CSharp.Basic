using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Collections.Generic
{
    public static class Queue
    {
        public static void Use_Queue() { 
        
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Dequeue());
        }
    }
}
