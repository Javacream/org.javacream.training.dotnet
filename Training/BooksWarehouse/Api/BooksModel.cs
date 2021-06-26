using System.Collections.Generic;
using BooksWarehouse.Api.Types;

namespace BooksWarehouse.Api
{
    interface BooksModel
    {
        string Create(string title);
        Book FindByIsbn(string isbn);
        List<Book> FindAll();
        void DeleteByIsbn(string isbn);
        void Update(Book book);
    }
}
