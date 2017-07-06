using System;
using Xunit;

namespace Fundamentals.Tests
{
    public class SimpleStackTests
    {
        [Fact]
        public void PushOntoEmptyStackCreatesStackWithOneElement()
        {
            int expectedValue = 1;
            SimpleStack ss = new SimpleStack();

            ss.Push(expectedValue);

            Assert.Equal(expectedValue, ss.Peek());
        }

        [Fact]
        public void PopOnEmptyStackThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => (new SimpleStack()).Pop());
        }

        [Fact]
        public void PeekOnEmptyStackThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => (new SimpleStack()).Peek());
        }

        [Fact]
        public void PopOnStackWithOneElementReturnsTheDataValue()
        {
            int expectedValue = 1;
            SimpleStack ss = new SimpleStack();

            ss.Push(expectedValue);

            int actualValue = ss.Pop();

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
