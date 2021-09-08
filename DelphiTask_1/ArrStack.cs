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
    class ArrStack : IFunc
    {
        /// <summary>
        /// Array that stores data.
        /// </summary>
        private int[] arrayStack;
        /// <summary>
        /// Array element index.
        /// </summary>
        private int currentIndex;
        /// <inheritdoc />
        public int Count { get { return currentIndex; } set { currentIndex = value; } }
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
            if (value > arrayStack.Length)
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
