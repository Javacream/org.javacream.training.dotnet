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

        [Test]
        public void PlayAroundWithObjects(){
            //b1 ist eine Referenz auf ein Objekt
            Book b1 = new Book("ISBN1", "Title1", 100, 19.99, true);
            DoSomethingWithReference(b1);
            Assert.AreEqual(101, b1.Pages);
            DoSomethingWithNewInternalBook(b1);
            Assert.AreEqual(101, b1.Pages);
            DoSomethingWithNewInternalBookAndRef(ref b1);
            Assert.AreEqual(103, b1.Pages);
            Book b2 = b1;
            b2.Pages = 104;
            Assert.AreEqual(104, b1.Pages);


        }

        private void PlayWithReference(Book b){
            b.Pages = 101;
        }
        private void PlayWithNewInternalBook(Book b){
            b = new Book("ISBN1", "Title1", 102, 19.99, true);
        }
        private void PlayWithNewInternalBookAndRef(ref Book b){
            b = new Book("ISBN1", "Title1", 103, 19.99, true);
        }


    }
}