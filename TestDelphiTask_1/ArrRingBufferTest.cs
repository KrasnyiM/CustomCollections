using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DelphiTask_1;

namespace TestDelphiTask_1
{
    public class ArrRingBufferTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            //Arrange
            ArrRingBuffer<int> sut = new ArrRingBuffer<int>(1);
            int expected = 7;
            sut.Push(expected);

            //Act
            int result = sut.Peek();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pop_IfContainElements_ReturnFirst()
        {
            //Arrange
            ArrRingBuffer<int> sut = new ArrRingBuffer<int>(1);
            int expected= 7;
            sut.Push(expected);

            //Act
            int result = sut.Pop();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pop_IfContaineElements_RemoveFirst()
        {
            //Arrange
            ArrRingBuffer<int> sut = new ArrRingBuffer<int>(2);
            int first= 7;
            int expected = 3;
            sut.Push(first);
            sut.Push(expected);

            //Act
            sut.Pop();
            int result = sut.Pop();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Push_AddElements()
        {
            //Arrange
            ArrRingBuffer<int> sut = new ArrRingBuffer<int>(1);

            //Act
            int initial = sut.Count;
            sut.Push(12);

            //Assert
            Assert.Equal(initial, 0);
            Assert.Equal(sut.Count, 1);
        }

    }
}
