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
    public class LinkedListQueue : IFunc
    {
        /// <summary>
        /// The field that stores the first item.
        /// </summary>
        public MyLinkedListNode Head { get; set; }
        /// <summary>
        /// The field that stores the last item.
        /// </summary>
        public MyLinkedListNode Tail { get; set; }
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
        public void Push(int value)
        {
            MyLinkedListNode node = new MyLinkedListNode(value);

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
        public int Pop()
        {
            if (Count == 0)
            {
                return default;
            }

            int value = Head.Data;
            Head = Head.Next;
            Count--;
            return value;
        }
        ///<inheritdoc/>
        public int Peek()
        {
            if (Count == 0)
            {
                return default;
            }
            return Head.Data;
        }
    }
}
