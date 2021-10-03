using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelphiTask_1;
using Xunit;

namespace TestDelphiTask_1
{
    public class ArrStackTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            ArrStack arr = new ArrStack(3);

            int first = 7;
            int second = 3;
            int third = 5;

            arr.Push(first);
            arr.Push(second);
            arr.Push(third);

            int firstNumber = arr.Peek();

            Assert.Equal(third, firstNumber);
        }

        [Fact]
        public void Pop_IfContainElements_ReturnFirst()
        {
            ArrStack arr = new ArrStack(3);

            int first = 7;
            int second = 3;
            int third = 5;

            arr.Push(first);
            arr.Push(second);
            arr.Push(third);

            int firstNumber = arr.Pop();

            Assert.Equal(third, firstNumber);
        }

        [Fact]
        public void Pop_IfContaineElements_RemoveFirst()
        {
            ArrStack arr = new ArrStack(3);

            int first = 7;
            int second = 3;
            int third = 5;

            arr.Push(first);
            arr.Push(second);
            arr.Push(third);

            arr.Pop();
            int secondNumber = arr.Pop();

            Assert.NotEqual(third, secondNumber);
        }

        [Fact]
        public void Push_AddElements()
        {
            ArrStack arr = new ArrStack(3);

            arr.Push(1);
            arr.Push(2);
            arr.Push(3);

            Assert.True(arr.Count > 0, "Count = 0");
        }
    }
}
