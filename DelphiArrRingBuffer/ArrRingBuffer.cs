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
    public class ArrRingBuffer<T> : IFunc<T>
    {
        private T[] arrBuffer;
        private int head;
        private int tail;
        private int popIndex;
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
        /// <summary>
        /// Indexer for obtaining and installing array elements.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                index += popIndex;
                if (index >= arrBuffer.Length)
                {
                    return default;
                }
                return arrBuffer[index];
            }
            set
            {
                arrBuffer[index] = value;
            }
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

            T result = arrBuffer[tail];
            Count--;
            tail = (tail+1) % arrBuffer.Length;
            popIndex = (popIndex + 1) % arrBuffer.Length;
            return result;
        }
    }
}
