using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelphiExceptions;
using DelphiEventArgs;

namespace DelphiTask_1
{
    /// <summary>
    /// MyLinkeList, Class which implement array based ring buffer.
    /// </summary>
    public class ArrRingBuffer<T> : IFunc<T>
    {
        public delegate void StatusElements(OwnEventArgs<T> args);
        public event StatusElements Notify;

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
        /// <summary>
        /// Indexer for obtaining and installing array elements.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {   
                if(index >= Count || index < 0)
                {
                    throw new ElementNotFound();
                }

                //index = (index + tail) % arrBuffer.Length;
                return arrBuffer[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new ElementNotFound();
                }

                //index = (index + tail) % arrBuffer.Length;
                arrBuffer[index] = value;
            }
        }
        /// <inheritdoc />
        public T Peek()
        {
            if (Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            Notify?.Invoke(new OwnEventArgs<T>("Element peeked", arrBuffer[tail]));

            return arrBuffer[tail];
        }
        /// <inheritdoc />
        public void Push(T value)
        {
            if (Count == arrBuffer.Length)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container full"));
                throw new ContainerFullException();
            }

            arrBuffer[head] = value;
            Count++;
            head = (head + 1) % arrBuffer.Length;

            Notify?.Invoke(new OwnEventArgs<T>("Element pushed", value));
        }
        /// <inheritdoc />
        public T Pop()
        {
            if(Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            T result = arrBuffer[tail];
            Count--;
            tail = (tail+1) % arrBuffer.Length;

            Notify?.Invoke(new OwnEventArgs<T>("Element poped", result));

            return result;
        }
        public void Show()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine(arrBuffer[i]);
            }
        }
    }
}
