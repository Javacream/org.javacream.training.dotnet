using Xunit;
using BooksWarehouse.Api;

namespace BooksWarehouseTests
{
    public class BooksTests
    {
        [Fact]
        public void testBook()
        {
            Assert.Equal("Book: isbn=ISBN1, title=Title1, pages=200, price=19,99, available=True", new Book("ISBN1", "Title1", 200, 19.99, true).ToString());
        }
    }
}
