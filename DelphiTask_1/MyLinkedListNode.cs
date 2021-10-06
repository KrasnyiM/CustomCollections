using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    /// <summary>
    /// MyLinkedListNode, Class which implement linked list node.
    /// </summary>
    public class MyLinkedListNode
    {
        /// <summary>
        /// Field which stores a data.
        /// </summary>
        public int Data { get; private set; }
        /// <summary>
        /// Property which stores a reference to the next element.
        /// </summary>
        public MyLinkedListNode Next { get; set; }
        /// <summary>
        /// Constructor for initializing fields.
        /// </summary>
        /// <param name="x"></param>
        public MyLinkedListNode(int x)
        {
            Data = x;
            Next = null;
        }
    }
}
