using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelphiExceptions;
using DelphiEventArgs;

namespace DelphiTask_1
{
    public class LinkedListRingBuffer<T> : IFunc<T>
    {
        public delegate void StatusElements(OwnEventArgs<T> args);
        public event StatusElements Notify;
        /// <summary>
        /// Property which stores a reference to the first element.
        /// </summary>
        public MyLinkedListNode<T> Head { get; set; }
        /// <summary>
        /// Property for read data.
        /// </summary>
        public MyLinkedListNode<T> Read { get; set; }
        /// <summary>
        /// Property which stores a reference to the last element.
        /// </summary>
        public MyLinkedListNode<T> Tail { get; set; }
        /// <summary>
        /// Property for write data.
        /// </summary>
        public MyLinkedListNode<T> Write { get; set; }
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
                MyLinkedListNode<T> node = new MyLinkedListNode<T>(default);
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
        public T Peek()
        {
            if (Count == 0)
            {
                throw new ContainerEmptyException();
            }
            return Read.Data;
        }
        ///<inheritdoc/>
        public T Pop()
        {
            if (Count == 0)
            {
                throw new ContainerEmptyException();
            }

            T value;
            value = Read.Data;
            Read = Read.Next;
            Count--;

            return value;
        }
        ///<inheritdoc/>
        public void Push(T value)
        {
            if (length == Count)
            {
                throw new ContainerFullException();
            }   
            
            Write.Data = value;
            Write = Write.Next;
            Count++;                                 
        }    
    }
}
