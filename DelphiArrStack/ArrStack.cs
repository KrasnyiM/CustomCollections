using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    /// <summary>
    /// ArrStack, Class which implement array based stack.
    /// </summary>
    public class ArrStack<T> : IFunc<T>
    {
        private T[] arrayStack;
        /// <inheritdoc />
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="length"></param>
        public ArrStack(int length)
        {
            Count = 0;
            arrayStack = new T[length];
        }
        /// <inheritdoc />
        public void Push(T value)
        {
            if (Count == arrayStack.Length)
            {
                return;
            }

            arrayStack[Count] = value;
            Count++;
        }
        /// <inheritdoc />
        public T Pop()
        {
            if (Count == 0)
            {                
                return default;
            }

            T value = arrayStack[Count - 1];
            Count--;
            return value;
        }
        /// <inheritdoc />
        public T Peek()
        {
            if(Count == 0)
            {
                return default;
            }
            return arrayStack[Count - 1];
        }
    }
}
