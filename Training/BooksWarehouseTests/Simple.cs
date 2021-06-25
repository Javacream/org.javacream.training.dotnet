using System;
using Xunit;
namespace BooksWarehouseTests
{
    public class Simple
    {
        [Fact]
        public void TestSimple()
        {
            Assert.Equal(2, 1 + 1);
        }
    }
}
