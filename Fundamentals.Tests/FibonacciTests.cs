using Xunit;

namespace Fundamentals.Tests
{
    public class FibonacciTests
    {
        public int Fibonacci(int number)
        {
            if (number == 0||number == 1)
                return 1;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        [Fact]
        public void FibonacciOfZeroIsOne()
        {
            Assert.Equal(1, Fibonacci(0));
        }

        [Fact]
        public void FibonacciOfOneIsOne()
        {
            Assert.Equal(1, Fibonacci(1));
        }

        [Fact]
        public void FibonacciOfTwoIsTwo()
        {
            Assert.Equal(2, Fibonacci(2));
        }

        [Fact]
        public void FibonacciOfThreeIsThree()
        {
            Assert.Equal(3, Fibonacci(3));
        }

        [Fact]
        public void FibonacciOfFourIsFive()
        {
            Assert.Equal(5, Fibonacci(4));
        }
    }
}
