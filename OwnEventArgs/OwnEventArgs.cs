using System;

namespace DelphiEventArgs
{
    public class OwnEventArgs <T> : EventArgs
    {
        public string Message { get; }
        public T Data { get; }
        public OwnEventArgs(string message)
        {
            Message = message;
        }
        public OwnEventArgs(string message, T value) 
        {
            Message = message;
            Data = value;
        }
    }
}
