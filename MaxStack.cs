using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class MaxStack
    {
        Stack<int> _stack = new Stack<int>();
        Stack<int> _maxStack = new Stack<int>();
        public void Push(int item)
        {
            _stack.Push(item);

            if (_maxStack.Count == 0 || item >= _maxStack.Peek())
            {
                _maxStack.Push(item);
            }
        }

        public int Pop()
        {
            var item = _stack.Pop();
            if (item == _maxStack.Peek())
            {
                _maxStack.Pop();
            }
            return item;
        }

        public int GetMax()
        {
            return _maxStack.Peek();

        }
    }
}
