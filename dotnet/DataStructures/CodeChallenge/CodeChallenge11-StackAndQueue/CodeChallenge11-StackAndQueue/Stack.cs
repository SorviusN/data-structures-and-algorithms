using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge11_StackAndQueue
{
  public class Stack<T>
  {
    public Node<T> Top { get; set; }

    public bool IsEmpty()
    {
      if (Top == null) return true;
      else return false;
    }

    public void Push(T val)
    {
      Console.WriteLine(val);
      // Create a new node, with type T.
      Node<T> node = new Node<T>(val);

      // pushing that node to the top.
      node.Next = Top;
      Top = node;
    }

    public T Pop()
    {
      // Creating a reference node to the top value in the stack.
      Node<T> currentTop = Top;

      if (currentTop == null) throw new NullReferenceException();
      // Setting the Top of the stack to the next value.
      Top = currentTop.Next;

      // get back the new value.
      return currentTop.Value;
    }

    public bool Peek()
    {
      if (Top != null) return true;
      else return false;
    }
  }
}
