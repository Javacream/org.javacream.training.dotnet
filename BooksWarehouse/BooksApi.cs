using System.Collections.Generic;

namespace Javacream.BooksWarehouse.Api{
    public class Book{

        public string Isbn {get;}
        public string Title {get;}
        public int Pages {get;set;}
        public double Price {get;set;}
        public bool Available {get;set;}

        public Book(string isbn, string title, int pages, double price, bool available){
            Isbn = isbn;
            Title = title;
            Pages = pages;
            Price = price;
            Available = available;
         }
    }
    public interface IBooksModel{
        string Create(string title);
        Book FindByIsbn(string isbn);
        void DeleteByIsbn(string isbn);
        List<Book> FindAll();
        void Update(Book book);
        List<string> FindAllIsbns();
        List<Book> FindByTitle(string title);
        List<Book> FindByPriceRange(double min, double max);

    }
}