using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    /// <summary>
    /// MyLinkeList, Class which implement array based ring buffer.
    /// </summary>
    public class ArrRingBuffer <T> : IFunc <T>
    {
        private T[] arrBuffer;
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
            arrBuffer = new T[length];
        }
        /// <inheritdoc />
        public T Peek()
        {
            if (Count == 0)
            {
                return default;
            }
            return arrBuffer[tail];
        }
        /// <inheritdoc />
        public void Push(T value)
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
        public T Pop()
        {
            if(Count == 0)
            {
                return default;
            }

            var result = arrBuffer[tail];
            Count--;
            tail = (tail+1) % arrBuffer.Length;            
            return result;
        }
    }
}
