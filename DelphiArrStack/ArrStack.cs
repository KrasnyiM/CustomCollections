using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelphiExceptions;

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
                throw new ContainerFullException();
            }

            arrayStack[Count] = value;
            Count++;
        }
        /// <inheritdoc />
        public T Pop()
        {
            if (Count == 0)
            {
                throw new ContainerEmptyException();
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
                throw new ContainerEmptyException();
            }
            return arrayStack[Count - 1];
        }
    }
}
