using System;
using Xunit;
using Javacream.BooksWarehouse.Api;
using Javacream.BooksWarehouse.Impl;

namespace BooksWarehouse.Test
{
    public class BooksWarehouseTests
    {
        [Fact]
        public void TestBookCreation()
        {
            MapBooksModel model = new MapBooksModel();
            string isbn = model.Create(".NET");
            Book book = model.FindByIsbn(isbn);
            Assert.Equal(".NET", book.Title);
        }
    }
}

