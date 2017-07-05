using Xunit;

namespace Fundamentals.Tests
{
    public class SimpleNodeTests
    {
        [Fact]
        public void InitializeSimpleNodeCreatesOneNodeSinglyLinkedList()
        {
            int expectedValue = 1;
            SimpleNode sn = new SimpleNode(expectedValue);

            Assert.NotNull(sn);
            Assert.Equal(expectedValue, sn.Data);
            Assert.Null(sn.Next);
        }
    }
}
