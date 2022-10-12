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
    /// MyLinkeList, Class which implement array based queue.
    /// </summary>
    public class ArrQueue<T> : IFunc<T>
    {

        public delegate void StatusElements(OwnEventArgs<T> args);
        public event StatusElements Notify;        

        private T[] arrayQueue;
        ///<inheritdoc/>
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="length"></param>
        public ArrQueue(int length)
        {
            Count = 0;
            arrayQueue = new T[length];          
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
                if (index >= Count || index < 0)
                {
                    throw new ElementNotFound();
                }
                return arrayQueue[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new ElementNotFound();
                }
                arrayQueue[index] = value;
            }
        }
        ///<inheritdoc/>
        public T Peek()
        {
            if (Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            Notify?.Invoke(new OwnEventArgs<T>("Element peeked", arrayQueue[0]));

            return arrayQueue[0];
        }
        ///<inheritdoc/>
        public T Pop()
        {
            if (Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            T value = arrayQueue[0];

            for (int i = 0; i < Count - 1; i++)
            {
                arrayQueue[i] = arrayQueue[i + 1];
            }

            arrayQueue[Count - 1] = default;
            Count--;

            Notify?.Invoke(new OwnEventArgs<T>("Element poped", value));

            return value;
        }
        ///<inheritdoc/>
        public void Push(T value)
        {
            if (Count == arrayQueue.Length)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container full"));
                throw new ContainerFullException();
            }
            
            arrayQueue[Count] = value;
            Count++;

            Notify?.Invoke(new OwnEventArgs <T> ("Element pushed", value));           
        }
    }
}
