using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DelphiTask_1;

namespace TestProjectForList
{
    public class LinkedListRingBufferTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            //Arrange
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(1);
            int expected = 7;
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
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(1);
            int expected = 7;
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
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(2);
            int first = 7;
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
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(1);

            //Act
            int initial = sut.Count;
            sut.Push(12);

            //Assert
            Assert.Equal(initial, 0);
            Assert.Equal(sut.Count, 1);
        }

        [Fact]
        public void Pop_IfNotContaineElements_ReturnDefault()
        {
            //Arrange
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(1);

            //Act
            int expected = sut.Pop();

            //Assert
            Assert.Equal(expected, 0);
        }

        [Fact]
        public void Peek_IfNotContaineElements_ReturnDefault()
        {
            //Arrange
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(1);

            //Act
            int expected = sut.Peek();

            //Assert
            Assert.Equal(expected, 0);
        }
    }
}
