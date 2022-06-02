using NUnit.Framework;
using Javacream.BooksWarehouse;

namespace Javacream.BooksWarehouse.Test
{
    public class BooksWarehouseTests{

        [Test]
        public void ConstructingBookWithISBN1HasISBN1(){
            Book b1 = new Book("ISBN1", "Title1", 100, 19.99, true);
            Assert.AreEqual("ISBN1", b1.Isbn);
        }

    }
}