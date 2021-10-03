using System;
using Xunit;
using DelphiTask_1;

namespace TestDelphiTask_1
{
    
    public class ArrQueueTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            ArrQueue arr = new ArrQueue(3);

            int first = 7;
            int second = 3;
            int third = 5;

            arr.Push(first);
            arr.Push(second);
            arr.Push(third);

            int firstNumber = arr.Peek();

            Assert.Equal(first, firstNumber);
        }

        [Fact]
        public void Pop_IfContaineElements_ReturnFirst()
        {
            ArrQueue arr = new ArrQueue(3);

            int first = 7;
            int second = 3;
            int third = 5;

            arr.Push(first);
            arr.Push(second);
            arr.Push(third);

            int firstNumber = arr.Pop();

            Assert.Equal(first, firstNumber);
        }

        [Fact]
        public void Pop_IfContaineElements_RemoveFirst()
        {
            ArrQueue arr = new ArrQueue(3);

            int first = 7;
            int second = 3;
            int third = 5;

            arr.Push(first);
            arr.Push(second);
            arr.Push(third);

            arr.Pop();
            int secondNumber = arr.Pop();

            Assert.NotEqual(first, secondNumber);
        }

        [Fact]
        public void Push_AddElements()
        {
            ArrQueue arr = new ArrQueue(3);

            arr.Push(1);
            arr.Push(2);
            arr.Push(3);

            Assert.True(arr.Count>0,"Count = 0");
            
        }

    }
}
