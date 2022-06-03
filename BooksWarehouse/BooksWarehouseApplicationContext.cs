using System.Collections.Generic;
using Javacream.BooksWarehouse.Api;
using Javacream.BooksWarehouse.Impl;
namespace Javacream.BooksWarehouse{
    public static class ApplicationContext{
        static ApplicationContext(){
            var model = new DictionaryBooksModel();
            var data = new Dictionary<string, Book>();
            for (int i = 1; i <= 10; i++){
                Book b = new ("ISBN" + i, "Book" + i + "Title", 10*i, 9.99*i, false);
                data.Add(b.Isbn, b);
            }
            model._books = data;
            Model = model;
        }
        public static IBooksModel Model {get;}
    }
}