using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelphiExceptions;

namespace DelphiTask_1
{
    /// <summary>
    /// MyLinkeList, Class which implement linked list.
    /// </summary>
    public class LinkedListStack<T> : IFunc<T>
    {
        /// <summary>
        /// Property which stores a reference to the current element.
        /// </summary>
        public MyLinkedListNode<T> Head { get; set; }
        /// <inheritdoc/>
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        public LinkedListStack()
        {
            Head = null;
            Count = 0;
        }
        /// <inheritdoc/>
        public void Push(T value)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(value);
            node.Next = Head;
            Head = node;
            Count++;
        }
        /// <inheritdoc/>
        public T Pop()
        {
            if(Count == 0)
            {
                throw new ContainerEmptyException();
            }

            T value = Head.Data;
            Head = Head.Next;
            Count--;

            return value;
        }
        /// <inheritdoc/>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new ContainerEmptyException();
            }

            return Head.Data;
        }
    }
}
