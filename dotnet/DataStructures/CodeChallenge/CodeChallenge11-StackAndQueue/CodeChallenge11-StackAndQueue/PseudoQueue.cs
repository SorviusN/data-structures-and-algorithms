using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge11_StackAndQueue
{
  public class PseudoQueue<T>
  {
    Stack<T> stack1 = new Stack<T>();
    Stack<T> stack2 = new Stack<T>();

    public void Enqueue(T val)
    {
      stack1.Push(val);
      Console.WriteLine($"{val} was pushed");
    }

    public T Dequeue()
    {
      if (!stack1.Peek()) throw new NullReferenceException();
      while (stack1.Peek())
      {
        stack2.Push(stack1.Pop());
      }
      T temp = stack2.Pop();
      while (stack2.Peek())
      {
        stack1.Push(stack2.Pop());
      }
      Console.WriteLine($"{temp} popped off.");
      return temp;
    }
  }
}
