using System;
using stackandqueue.Classes;

namespace stackandqueue
{
    class Program
    {
      static void Main(string[] args)
      {

      Stack<string> stack = new Stack<string>();

      stack.Push("Butter");
      stack.Push("Milk");
      stack.Push("Eggs");

      string popped = stack.Pop();

      Console.WriteLine($"{popped} was popped off the stack.");

      Queue<int> q = new Queue<int>();
      q.Enqueue(1);
      Console.WriteLine(q.Peek());
      q.Enqueue(10);

      Console.WriteLine("Dequeued val");
      Console.WriteLine(q.Dequeue());
      Console.WriteLine(q.Peek());
      q.Dequeue();
      Console.WriteLine(q.IsEmpty());
        
      }
    }
}
