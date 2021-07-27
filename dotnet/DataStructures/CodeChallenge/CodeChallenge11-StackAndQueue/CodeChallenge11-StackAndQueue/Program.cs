using System;

namespace CodeChallenge11_StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
      PseudoQueue<int> queue = new PseudoQueue<int>();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      queue.Dequeue();

        }
    }
}
