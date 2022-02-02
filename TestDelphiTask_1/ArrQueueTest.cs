using System;
using Xunit;
using DelphiTask_1;
using DelphiExceptions;

namespace TestDelphiTask_1
{
    public class ArrQueueTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {
            //Arrange
            ArrQueue<int> sut = new ArrQueue<int>(1);
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
            ArrQueue<int> sut = new ArrQueue<int>(1);
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
            ArrQueue<int> sut = new ArrQueue<int>(2);
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
            ArrQueue<int> sut = new ArrQueue<int>(1);

            //Act
            int initial = sut.Count;
            sut.Push(12);

            //Assert
            Assert.Equal(initial, 0);
            Assert.Equal(sut.Count, 1);
        }

        [Fact]
        public void Indexer_ReadElements()
        {
            //Arrange
            ArrQueue<int> sut = new ArrQueue<int>(1);
            sut.Push(1);

            //Act
            int expected = sut[0];

            //Assert
            Assert.Equal(expected, 1);
        }

        [Fact]
        public void Indexer_SetElenents()
        {
            //Arrange
            ArrQueue<int> sut = new ArrQueue<int>(1);
            sut.Push(1);

            //Act
            sut[0] = 22;
            int expected = sut[0];

            //Assert
            Assert.Equal(expected, 22);
        }

        [Fact]
        public void Indexer_ReturnException()
        {
            //Arrange
            ArrQueue<int> sut = new ArrQueue<int>(1);
            sut.Push(1);

            //Act

            //Assert
            Assert.Throws<ElementNotFound>(() => sut[9]);
        }
    }
}
