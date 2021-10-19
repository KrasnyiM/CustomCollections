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
        /// <summary>
        /// Constructor for initializing fields and create ring buffer.
        /// </summary>
        /// <param name="value"></param>
        public LinkedListRingBuffer(int value)
        {
            Head = null;
            Count = 0;
            length = value;
            CreateRingBuffer();
        }
        /// <summary>
        /// The method which creates ring buffer.
        /// </summary>
        public void CreateRingBuffer()
        {
            for (int i = 0; i < length; i++)
            {
                MyLinkedListNode node = new MyLinkedListNode(0);
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
            
            Write.Data = value;
            Write = Write.Next;
            Count++;                                 
        }    
    }
}
