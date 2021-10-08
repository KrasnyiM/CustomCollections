using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    public class ArrQueue : IFunc
    {
        private int[] arrayQueue;
        ///<inheritdoc/>
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="length"></param>
        public ArrQueue(int length)
        {
            Count = 0;
            arrayQueue = new int[length];
        }
        ///<inheritdoc/>
        public int Peek()
        {
            if (Count == 0)
            {
                return default;
            }
            return arrayQueue[0];
        }
        ///<inheritdoc/>
        public int Pop()
        {
            if (Count == 0)
            {
                return default;
            }

            int value = arrayQueue[0];

            for (int i = 0; i < Count - 1; i++)
            {
                arrayQueue[i] = arrayQueue[i + 1];
            }

            arrayQueue[Count - 1] = 0;
            Count--;
            return value;
        }
        ///<inheritdoc/>
        public void Push(int value)
        {
            if (Count == arrayQueue.Length)
            {
                return;
            }

            arrayQueue[Count] = value;
            Count++;
        }
    }
}
