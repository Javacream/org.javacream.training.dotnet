using System.Collections.Generic;

namespace Javacream.BooksWarehouse.Api
{
    public interface BooksModel
    {
        string Create(string title);
        Book FindByIsbn(string isbn);
        List<Book> FindAll();
        void DeleteByIsbn(string isbn);
        void Update(Book book);
        List<string> FindAllIsbns();

    }

}