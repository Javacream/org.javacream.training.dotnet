using System;
using Javacream.BooksWarehouse.Api;
using Javacream.BooksWarehouse.Impl;
namespace SimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksModel booksModel = new MapBooksModel();
            string isbn = booksModel.Create("Title1");
            Book book = booksModel.FindByIsbn(isbn);
            Console.WriteLine(book.ToString());
        }
    }
}
