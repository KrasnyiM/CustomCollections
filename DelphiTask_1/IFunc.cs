using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiTask_1
{
    /// <summary>
    /// The interface that declares the field and methods for inheritance.
    /// </summary>
    interface IFunc <T>
    {
        /// <summary>
        /// Property that stores the number of elements.
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Method that adds elements to an array.
        /// </summary>
        /// <param name="value"></param>
        void Push(T value);
        /// <summary>
        /// Method that retrieves first item.
        /// </summary>
        /// <returns>First value</returns>
        T Pop();
        /// <summary>
        /// Just returns first value.
        /// </summary>
        /// <returns>First value</returns>
        T Peek();
    }
}
