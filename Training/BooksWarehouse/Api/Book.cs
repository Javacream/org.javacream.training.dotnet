using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWarehouse.Api
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int Pages{ get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }

        public Book(string isbn, string title, int pages, double price, bool available)
        {
            Isbn = isbn;
            Title = title;
            Pages = pages;
            Price = price;
            Available = available;
        }
        public Book()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   Isbn == book.Isbn &&
                   Title == book.Title &&
                   Pages == book.Pages &&
                   Price == book.Price &&
                   Available == book.Available;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Isbn, Title, Pages, Price, Available);
        }

        public override string ToString()
        {
            return $"Book: isbn={Isbn}, title={Title}, pages={Pages}, price={Price}, available={Available}";
        }
    }


}
