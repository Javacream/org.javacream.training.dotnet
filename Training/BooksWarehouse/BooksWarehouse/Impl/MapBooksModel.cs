
using System;
using System.Collections.Generic;
using Javacream.BooksWarehouse.Api;

namespace Javacream.BooksWarehouse.Impl
{    public class MapBooksModel : BooksModel
    {
        private Dictionary<string, Book> books = new Dictionary<string, Book>();
        private Random random = new Random();
        public string Create(string title)
        {
            string isbn = "ISBN:" + random.Next();
            books.Add(isbn, new Book(isbn, title, 100, 9.99, false));
            return isbn;
        }

        public void DeleteByIsbn(string isbn)
        {
            books.Remove(isbn);
        }
        
        public List<Book> FindAll()
        {
            return new List<Book>(books.Values);
        }

        public Book FindByIsbn(string isbn)
        {
            return books[isbn];
        }

        public void Update(Book book)
        {
            books.Add(book.Isbn, book);
        }
    }
}