namespace Javacream.BooksWarehouse{
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

}