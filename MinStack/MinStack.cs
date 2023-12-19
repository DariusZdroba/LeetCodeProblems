using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    public class MinStack
    {
        private Stack<int> _minStack;
        private Stack<int> _minCounterStack;
        private int min;
        public MinStack()
        {
            _minStack = new Stack<int>();
            _minCounterStack = new Stack<int>();
        }

        public void Push(int val)
        {
            if(_minStack.Count == 0) 
            {
                _minCounterStack.Push(val);
                min = val;
            }
            else if(val < min)
            {
                _minCounterStack.Push(val);
                min = val;
            }
            _minStack.Push(val);
        }

        public void Pop()
        {
            if(_minCounterStack.Count != 0)
            if(_minStack.Pop().Equals(_minCounterStack.Peek()))
            {
                _minCounterStack.Pop();
                min = _minCounterStack.Peek();
            }
        }

        public int Top()
        {
            return _minStack.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }
}
