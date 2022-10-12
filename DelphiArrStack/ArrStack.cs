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
    /// ArrStack, Class which implement array based stack.(LIFO)
    /// </summary>
    public class ArrStack<T> : IFunc<T>
    {
        public delegate void StatusElements(OwnEventArgs<T> args);
        public event StatusElements Notify;

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

                index = Count - index - 1;
                return arrayStack[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new ElementNotFound();
                }

                index = Count - index - 1;
                arrayStack[index] = value;
            }
        }
        /// <inheritdoc />
        public void Push(T value)
        {
            if (Count == arrayStack.Length)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container full"));
                throw new ContainerFullException();
            }

            arrayStack[Count] = value;
            Count++;

            Notify?.Invoke(new OwnEventArgs<T>("Element pushed", value));
        }
        /// <inheritdoc />
        public T Pop()
        {
            if (Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            T value = arrayStack[Count - 1];
            Count--;

            Notify?.Invoke(new OwnEventArgs<T>("Element poped", value));

            return value;
        }
        /// <inheritdoc />
        public T Peek()
        {
            if(Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            Notify?.Invoke(new OwnEventArgs<T>("Element peeked", arrayStack[Count - 1]));

            return arrayStack[Count - 1];
        }
    }
}
