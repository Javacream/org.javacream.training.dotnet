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
        public void PlayAroundWithTypeInference(){
            Book b1 = new Book("ISBN1", "Title1", 100, 19.99, true);
            var b2 = new Book("ISBN1", "Title1", 100, 19.99, true);
            Book b3 = new ("ISBN1", "Title1", 100, 19.99, true);

        }


        [Test]
        public void PlayAroundWithClassObjects(){
            //b1 ist eine Referenz auf ein Objekt
            Book b1 = new Book("ISBN1", "Title1", 100, 19.99, true);
            PlayWithReference(b1);
            Assert.AreEqual(101, b1.Pages);
            PlayWithNewInternalBook(b1);
            Assert.AreEqual(101, b1.Pages);
            PlayWithNewInternalBookAndRef(ref b1);
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

        [Test]
        public void PlayAroundWithStrucObjects(){
            //b1 ist eine Referenz auf ein Objekt
            BookStruct b1 = new BookStruct("ISBN1", "Title1", 100, 19.99, true);
            PlayWithStruct(b1);
            Assert.AreEqual(100, b1.Pages);
            BookStruct b2 = b1;
            b2.Pages = 104;
            Assert.AreEqual(100, b1.Pages);


        }
        private void PlayWithStruct(BookStruct b){
            b.Pages = 101;
        }


    }
}