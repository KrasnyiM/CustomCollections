using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    /// <summary>
    /// MyLinkeList, Class which implement linked list based queue.
    /// </summary>
    public class LinkedListQueue <T> : IFunc <T>
    {
        /// <summary>
        /// The field that stores the first item.
        /// </summary>
        public MyLinkedListNode <T> Head { get; set; }
        /// <summary>
        /// The field that stores the last item.
        /// </summary>
        public MyLinkedListNode <T> Tail { get; set; }
        ///<inheritdoc/>
        public int Count { get; set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        public LinkedListQueue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        ///<inheritdoc/>
        public void Push(T value)
        {
            MyLinkedListNode <T> node = new MyLinkedListNode<T>(value);

            if (Head == null)
            {
                Head = node; 
                Tail = node;
                Count++;
                return;
            }

            Tail.Next = node;
            Tail = node;
            Count++;
        }
        ///<inheritdoc/>
        public T Pop()
        {
            if (Count == 0)
            {
                return default;
            }

            var value = Head.Data;
            Head = Head.Next;
            Count--;
            return value;
        }
        ///<inheritdoc/>
        public T Peek()
        {
            if (Count == 0)
            {
                return default;
            }
            return Head.Data;
        }
    }
}
