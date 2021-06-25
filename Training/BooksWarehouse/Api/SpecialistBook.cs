using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWarehouse.Api.Types
{
    class SpecialistBook:Book
    {
        public string Subject { get; }

        public SpecialistBook(string isbn, string title, int pages, double price, bool available, string subject) : base(isbn, title, pages, price, available)
        {
            Subject = subject;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, subject={Subject}";
        }
    }
}
