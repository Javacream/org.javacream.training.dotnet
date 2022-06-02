using NUnit.Framework;
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
        public void PlayAroundWithTypeInference(){
            Book b1 = new Book("ISBN1", "Title1", 100, 19.99, true);
            var b2 = new Book("ISBN1", "Title1", 100, 19.99, true);
            Book b3 = new ("ISBN1", "Title1", 100, 19.99, true);

        }


        [Test]
        public void PlayAroundWithClassObjects(){
            void PlayWithReference(Book b){
                b.Pages = 101;
            }
            void PlayWithNewInternalBook(Book b){
                b = new Book("ISBN1", "Title1", 102, 19.99, true);
            }
            void PlayWithNewInternalBookAndRef(ref Book b){
                b = new Book("ISBN1", "Title1", 103, 19.99, true);
            }

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
            /*
            //Später
            Book b3 = b1.Clone();
            b3.Pages = 105;
            Assert.AreEqual(104, b1.Pages);
            */


        }


        [Test]
        public void PlayAroundWithStrucObjects(){
            //type <name> = Literal
            //string message = "Hello";
            Action<BookStruct> playWithStruct = (BookStruct b) => {
                b.Pages = 101;
            };
            BookStruct b1 = new BookStruct("ISBN1", "Title1", 100, 19.99, true);
            var x = playWithStruct;
            x(b1);
            Assert.AreEqual(100, b1.Pages);
            BookStruct b2 = b1;
            b2.Pages = 104;
            Assert.AreEqual(100, b1.Pages);


        }


    }
}