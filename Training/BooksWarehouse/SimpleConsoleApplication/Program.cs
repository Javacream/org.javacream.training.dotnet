using System;
using Javacream.BooksWarehouse.Api;
namespace SimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("ISBN1", "Title1", 200, 19.99, true);
            Console.WriteLine(book.ToString());
        }
    }
}
