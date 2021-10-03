﻿using System;
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
            ArrRingBuffer sut = new ArrRingBuffer(1);

            int expected= 7;

            sut.Push(expected);

            int result = sut.Peek();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pop_IfContainElements_ReturnFirst()
        {
            ArrRingBuffer sut = new ArrRingBuffer(1);

            int expected= 7;

            sut.Push(expected);

            int result = sut.Pop();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pop_IfContaineElements_RemoveFirst()
        {
            ArrRingBuffer sut = new ArrRingBuffer(2);

            int expected= 7;
            int first = 3;

            sut.Push(first);
            sut.Push(expected);

            sut.Pop();
            int result = sut.Pop();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Push_AddElements()
        {
            ArrRingBuffer sut = new ArrRingBuffer(1);

            int startCount = sut.Count;

            sut.Push(1);

            startCount = sut.Count - startCount;

            Assert.True(startCount > 0, "Don't have elements");
        }
    }
}