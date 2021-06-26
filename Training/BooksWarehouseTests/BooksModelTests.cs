using Xunit;
using BooksWarehouse.Impl;
namespace BooksWarehouseTests
{
 
        public class BooksModelTests
    {

        [Theory]
        [InlineData("Title1")]
        public void testBookCreation(string title)
        {
            var booksModel = new MapBooksModel();
            string isbn = booksModel.Create(title);
            Assert.NotNull(isbn);
            var book = booksModel.FindByIsbn(isbn);
            Assert.Equal(title, book.Title);
        }
    }
}
