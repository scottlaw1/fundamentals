using Xunit;

namespace Fundamentals.Tests
{
    public class NodeTests
    {
        [Fact]
        public void InitializeNodeSetupCreatesOneNodeDoublyLinkedList()
        {
            int expectedValue = 1;
            Node n = new Node(expectedValue);

            Assert.NotNull(n);
            Assert.Equal(expectedValue, n.Data);
            Assert.Null(n.Next);
            Assert.Null(n.Previous);
        }
    }
}
