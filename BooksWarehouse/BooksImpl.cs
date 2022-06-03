using Javacream.BooksWarehouse.Api;
using System.Collections.Generic;
namespace Javacream.BooksWarehouse.Impl{

    public class DictionaryBooksModel: IBooksModel{
        public Dictionary<string, Book> _books {get; set;}
        private int counter = 0;
       public string Create(string title){
           string isbn = "Isbn:" + counter++;
           Book newBook = new (isbn, title, 0, 0.0, false);
           _books.Add(isbn, newBook);
           return isbn;
       }
       public Book FindByIsbn(string isbn){
           return _books[isbn];
       }
       public void DeleteByIsbn(string isbn){
           _books.Remove(isbn);
       }
       public  List<Book> FindAll(){
           return new List<Book>(_books.Values);
       }
       public  void Update(Book book){
           _books[book.Isbn]= book;
       }

        public List<string> FindAllIsbns(){
            return FindAll().ConvertAll(book => book.Isbn);
        }
        public List<Book> FindByTitle(string title){
            return FindAll().FindAll(book => book.Title.Contains(title));
        }
        public List<Book> FindByPricerange(double min, double max){
            return FindAll().FindAll(book => book.Price > min && book.Price < max);
        }


 
    }

}