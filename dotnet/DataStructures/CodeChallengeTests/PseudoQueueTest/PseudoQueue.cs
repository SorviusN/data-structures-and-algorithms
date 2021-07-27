using System;
using Xunit;
using CodeChallenge11_StackAndQueue;

namespace PseudoQueueTest
{
    public class PseudoQueue
    {
        [Fact]
        public void CanEnqueueDequeueandException()
        {
      PseudoQueue<int> queue = new PseudoQueue<int>();
      queue.Enqueue(5);
      Assert.Equal(5, queue.Dequeue());
      Assert.Throws<NullReferenceException>(() => queue.Dequeue());
        }
    }
}
