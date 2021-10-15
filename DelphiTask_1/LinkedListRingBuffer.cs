using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    public class LinkedListRingBuffer : IFunc
    {
        /// <summary>
        /// Property which stores a reference to the first element.
        /// </summary>
        public MyLinkedListNode Head { get; set; }
        /// <summary>
        /// Property for read data.
        /// </summary>
        public MyLinkedListNode Read { get; set; }
        /// <summary>
        /// Property which stores a reference to the last element.
        /// </summary>
        public MyLinkedListNode Tail { get; set; }
        /// <summary>
        /// Property for write data.
        /// </summary>
        public MyLinkedListNode Write { get; set; }
        ///<inheritdoc/>
        public int Count { get;private set; }

        private int length;
        private int numberObj;
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="value"></param>
        public LinkedListRingBuffer(int value)
        {
            Head = null;
            Tail = null;
            Read = null;
            Write = null;
            Count = 0;
            length = value;
            numberObj = 0;
        }
        ///<inheritdoc/>
        public int Peek()
        {
            if (Count == 0)
            {
                return default;
            }
            return Read.Data;
        }
        ///<inheritdoc/>
        public int Pop()
        {
            if (Count == 0)
            {
                return default;
            }

            int value;
            value = Read.Data;
            Read = Read.Next;
            Count--;

            return value;
        }
        ///<inheritdoc/>
        public void Push(int value)
        {
            if (length == Count)
            {
                return;
            }
            if (numberObj < length)
            {
                MyLinkedListNode node = new MyLinkedListNode(value);
                Count++;
                numberObj++;
                if (Head == null)
                {
                    Head = node;
                    Write = Head;
                    Read = Head;
                }
                else
                {
                    Tail.Next = node;
                }
                Tail = node;
                Tail.Next = Head; 
            }
            else
            {
                Write.Data = value;
                Write = Write.Next;
                Count++;
            }                        
        }    
    }
}
