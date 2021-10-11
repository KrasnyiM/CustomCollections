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
            //Arrange
            ArrRingBuffer sut = new ArrRingBuffer(1);
            int expected= 7;
            sut.Push(expected);

            //Act
            int result = sut.Peek();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pop_IfContaineElements_ReturnFirst()
        {
            //Arrange
            ArrRingBuffer sut = new ArrRingBuffer(1);
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
            ArrRingBuffer sut = new ArrRingBuffer(2);
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
            ArrRingBuffer sut = new ArrRingBuffer(1);

            //Act
            int initial = sut.Count;
            sut.Push(12);

            //Assert
            Assert.Equal(initial, 0);
            Assert.Equal(sut.Count, 1);
        }
    }
}
