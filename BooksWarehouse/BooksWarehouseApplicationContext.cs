using System.Collections.Generic;
using Javacream.BooksWarehouse.Api;
using Javacream.BooksWarehouse.Impl;
namespace Javacream.BooksWarehouse{
    public static class ApplicationContext{
        static ApplicationContext(){
            var model = new SqlBooksModel();
            Model = model;
        }
        public static IBooksModel Model {get;}
    }
}