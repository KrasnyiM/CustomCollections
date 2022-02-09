using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiExceptions
{
    public class ContainerFullException : Exception
    {
        public ContainerFullException() : base()
        {

        }

        public ContainerFullException(string message) : base(message)
        {

        }

        public ContainerFullException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
