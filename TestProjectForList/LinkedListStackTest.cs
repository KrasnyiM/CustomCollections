using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DelphiTask_1;
using DelphiExceptions;

namespace TestProjectForList
{
    public class LinkedListStackTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            //Arrange
            LinkedListStack<int> sut = new LinkedListStack<int>();
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
            LinkedListStack<int> sut = new LinkedListStack<int>();
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
            LinkedListStack<int> sut = new LinkedListStack<int>();
            int second = 7;
            int expected = 3;
            sut.Push(expected);
            sut.Push(second);

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
            LinkedListStack<int> sut = new LinkedListStack<int>();

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

            //Assert
            Assert.Throws<ContainerEmptyException>(() => sut.Pop());
        }

        [Fact]
        public void Peek_IfNotContaineElements_ReturnDefault()
        {
            //Arrange
            LinkedListRingBuffer<int> sut = new LinkedListRingBuffer<int>(1);

            //Act

            //Assert
            Assert.Throws<ContainerEmptyException>(() => sut.Pop());
        }
    }
}
