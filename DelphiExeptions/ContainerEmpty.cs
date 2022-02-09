using System;

namespace DelphiExceptions
{
    public class ContainerEmptyException : Exception 
    {
        public ContainerEmptyException() : base()
        {

        }

        public ContainerEmptyException(string message) : base(message)
        {

        }

        public ContainerEmptyException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
