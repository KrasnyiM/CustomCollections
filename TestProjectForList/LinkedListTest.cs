using System;
using Xunit;
using DelphiTask_1; 

namespace TestProjectForList
{
    public class LinkedListTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            //Arrange
            MyLinkedList<int> sut = new MyLinkedList<int>();
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
            MyLinkedList<int> sut = new MyLinkedList<int>();
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
            MyLinkedList<int> sut = new MyLinkedList<int>();
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
            MyLinkedList<int> sut = new MyLinkedList<int>();

            //Act
            int initial = sut.Count;
            sut.Push(12);

            //Assert
            Assert.Equal(initial, 0);
            Assert.Equal(sut.Count, 1);
        }
    }
}
