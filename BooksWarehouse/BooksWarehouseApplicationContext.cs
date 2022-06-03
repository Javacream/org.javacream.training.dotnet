using Javacream.BooksWarehouse.Api;
using Javacream.BooksWarehouse.Impl;
namespace Javacream.BooksWarehouse{
    public static class ApplicationContext{
        public static IBooksModel Model = new DictionaryBooksModel();
    }
}