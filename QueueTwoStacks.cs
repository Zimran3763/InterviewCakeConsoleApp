using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class QueueTwoStacks
    {
        private Stack<int> _inStack = new Stack<int>();
        private Stack<int> _outStack = new Stack<int>();

        public  void Enqueue(int item)
        {
            _inStack.Push(item);
        }

        public int Dequeue()
        {
            if (_outStack.Count == 0)
            {
                // Move items from inStack to outStack, reversing order
                while (_inStack.Count > 0)
                {
                    int newestInStackItem = _inStack.Pop();
                    _outStack.Push(newestInStackItem);
                }

                // If outStack is still empty, raise an error
                if (_outStack.Count == 0)
                {
                    throw new InvalidOperationException("Can't dequeue from empty queue!");
                }
            }

            return _outStack.Pop();
        }
    }
}
