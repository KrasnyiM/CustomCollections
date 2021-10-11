using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    public class ArrRingBuffer : IFunc
    {
        private int[] arrBuffer;
        private int head;
        private int tail;
        /// <inheritdoc />
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="length"></param>
        public ArrRingBuffer(int length)
        {
            head = 0;
            tail = 0;
            arrBuffer = new int[length];
        }
        /// <inheritdoc />
        public int Peek()
        {
            if (Count == 0)
            {
                return default;
            }
            return arrBuffer[tail];
        }
        /// <inheritdoc />
        public void Push(int value)
        {
            if (Count == arrBuffer.Length)
            {
                return;
            }

            arrBuffer[head] = value;
            Count++;
            head = (head + 1) % arrBuffer.Length;             
        }
        /// <inheritdoc />
        public int Pop()
        {
            if(Count == 0)
            {
                return default;
            }

            int result = arrBuffer[tail];
            Count--;
            tail = (tail+1) % arrBuffer.Length;            
            return result;
        }
    }
}
