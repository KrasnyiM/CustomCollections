using System;
using DelphiExceptions;
using DelphiEventArgs;

namespace DelphiTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrRingBuffer<int> queue = new ArrRingBuffer<int>(5);
            //queue.Notify += DisplayMessage;
            //queue.Push(1);
            //queue.Push(2);
            //queue.Push(3);
            //queue.Push(4);
            //queue.Push(5);
            //queue.Peek();
            //queue.Pop();
            //queue.Push(6);
            //Console.WriteLine(queue[0]);
            //queue.Show();
            MyLinkedList<int> arr = new MyLinkedList<int>();
            arr.Push(1);
            arr.Push(2);
            arr.Push(3);
            arr.Push(4);
            arr.Push(5);

        }

        //public static void DisplayMessage(OwnEventArgs<int> value)
        //{
        //    Console.Write($"{value.Message}\t");
        //    Console.WriteLine(value.Data);
        //}
        
    }
}
