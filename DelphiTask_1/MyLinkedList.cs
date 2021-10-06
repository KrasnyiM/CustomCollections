using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    /// <summary>
    /// MyLinkeList, Class which implement linked list.
    /// </summary>
    public class MyLinkedList :IFunc
    {
        /// <summary>
        /// Property which stores a reference to the current element.
        /// </summary>
        public MyLinkedListNode Head { get; set; }
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
        public void Push(int value)
        {
            MyLinkedListNode node = new MyLinkedListNode(value);
            node.Next = Head;
            Head = node;
            Count++;
        }
        /// <inheritdoc/>
        public int Pop()
        {
            int value = Head.Data;
            Head = Head.Next;
            Count--;

            return value;
        }
        /// <inheritdoc/>
        public int Peek()
        {
            return Head.Data;
        }
    }
}
