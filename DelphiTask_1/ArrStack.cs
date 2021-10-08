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
    public class ArrStack : IFunc
    {
        private int[] arrayStack;
        /// <inheritdoc />
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="length"></param>
        public ArrStack(int length)
        {
            Count = 0;
            arrayStack = new int[length];
        }
        /// <inheritdoc />
        public void Push(int value)
        {
            if (Count == arrayStack.Length)
            {
                return;
            }

            arrayStack[Count] = value;
            Count++;
        }
        /// <inheritdoc />
        public int Pop()
        {
            if (Count == 0)
            {                
                return default;
            }

            int value = arrayStack[Count - 1];
            Count--;
            return value;
        }
        /// <inheritdoc />
        public int Peek()
        {
            if(Count == 0)
            {
                return default;
            }
            return arrayStack[Count - 1];
        }
    }
}
