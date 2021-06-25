using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWarehouse.Api.Types
{
    class SchoolBook:Book
    {
        public SchoolBook()
        {
        }

        public SchoolBook(string isbn, string title, int pages, double price, bool available, int year) : base(isbn, title, pages, price, available)
        {
            Year = year;
        }

        public int Year { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, year={Year}";
        }
    }
}
