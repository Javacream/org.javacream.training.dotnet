using NUnit.Framework;
using Javacream.BooksWarehouse.Api;
using Javacream.BooksWarehouse;
using System;

namespace Javacream.BooksWarehouse.Test
{
    public class BooksWarehouseTests{

        [Test]
        public void ConstructingBookWithISBN1HasISBN1(){
            Book b1 = new Book("ISBN1", "Title1", 100, 19.99, true);
            Assert.AreEqual("ISBN1", b1.Isbn);
        }

        [Test]
        public void BooksModelWorks(){
            string title = "TEST";
            IBooksModel model = ApplicationContext.Model;
            string generatedIsbn = model.Create(title);
            Assert.NotNull(generatedIsbn);
            Book searchResult = model.FindByIsbn(generatedIsbn);
            Assert.AreEqual(title, searchResult.Title);
            Assert.AreEqual(generatedIsbn, searchResult.Isbn);
        }
        [Test]
        public void FindBookByIsbnISBN1FindsBookWithTitleBook1Title(){
            string isbn = "ISBN1";
            IBooksModel model = ApplicationContext.Model;
            var book = model.FindByIsbn(isbn);
            Assert.AreEqual("Book1Title", book.Title);
        }
        [Test]
        public void FindBookByIsbnISBN42FindsNoBook(){
            string isbn = "ISBN42";
            IBooksModel model = ApplicationContext.Model;
            Assert.Throws<System.Collections.Generic.KeyNotFoundException>(() => model.FindByIsbn(isbn));
        }

    }
}