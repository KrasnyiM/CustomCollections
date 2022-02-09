using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DelphiTask_1;
using DelphiExceptions;

namespace TestProjectForList
{
    public class LinkedListQueueTest
    {
        [Fact]
        public void Peek_IfContainElements_ReturnFirst()
        {            
            //Arrange
            LinkedListQueue<int> sut = new LinkedListQueue<int>();
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
            LinkedListQueue<int> sut = new LinkedListQueue<int>();
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
            LinkedListQueue<int> sut = new LinkedListQueue<int>();
            int second = 7;
            int expected = 3;
            sut.Push(second);
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
            LinkedListQueue<int> sut = new LinkedListQueue<int>();

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
            LinkedListQueue<int> sut = new LinkedListQueue<int>();

            //Act

            //Assert
            Assert.Throws<ContainerEmptyException>(() => sut.Pop());
        }

        [Fact]
        public void Peek_IfNotContaineElements_ReturnDefault()
        {
            //Arrange
            LinkedListQueue<int> sut = new LinkedListQueue<int>();

            //Act

            //Assert
            Assert.Throws <ContainerEmptyException>(() => sut.Peek());
        }
    }
}
