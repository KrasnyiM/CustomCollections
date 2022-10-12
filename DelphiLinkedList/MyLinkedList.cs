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
    /// MyLinkeList, Class which implement linked list.
    /// </summary>
    public class MyLinkedList<T> : IFunc<T>
    {
        public delegate void StatusElements(OwnEventArgs<T> args);
        public event StatusElements Notify;

        /// <summary>
        /// Property which stores a reference to the current element.
        /// </summary>
        public MyLinkedListNode<T> Head { get; set; }
        /// <inheritdoc/>
        public int Count { get; private set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        public MyLinkedList()
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

            Notify?.Invoke(new OwnEventArgs<T>("Element pushed", value));
        }
        /// <inheritdoc/>
        public T Pop()
        {
            if (Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }

            T value = Head.Data;
            Head = Head.Next;
            Count--;

            Notify?.Invoke(new OwnEventArgs<T>("Element poped", value));

            return value;
        }
        /// <inheritdoc/>
        public T Peek()
        {
            if(Count == 0)
            {
                Notify?.Invoke(new OwnEventArgs<T>("Container empty"));
                throw new ContainerEmptyException();
            }
            Notify?.Invoke(new OwnEventArgs<T>("Element peeked", Head.Data));

            return Head.Data;
        }
    }
}
