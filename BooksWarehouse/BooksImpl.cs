using Javacream.BooksWarehouse.Api;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace Javacream.BooksWarehouse.Impl{

    public class DictionaryBooksModel: IBooksModel{
        public Dictionary<string, Book> _books {get; set;}
        private int counter = 0;
       public string Create(string title){
           string isbn = "Isbn:" + counter++;
           Book newBook = new (isbn, title, 0, 0.0, false);
           _books.Add(isbn, newBook);
           return isbn;
       }
       public Book FindByIsbn(string isbn){
           return _books[isbn];
       }
       public void DeleteByIsbn(string isbn){
           _books.Remove(isbn);
       }
       public  List<Book> FindAll(){
           return new List<Book>(_books.Values);
       }
       public  void Update(Book book){
           _books[book.Isbn]= book;
       }

        public List<string> FindAllIsbns(){
            return FindAll().ConvertAll(book => book.Isbn);
        }
        public List<Book> FindByTitle(string title){
            return FindAll().FindAll(book => book.Title.Contains(title));
        }
        public List<Book> FindByPriceRange(double min, double max){
            return FindAll().FindAll(book => book.Price > min && book.Price < max);
        }


 
    }

    public class SqlBooksModel : IBooksModel
    {
        private readonly string connectionString = "Data Source=h2908727.stratoserver.net;Initial Catalog=publishing;User ID=sa;Password=javacream123!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DbProviderFactory sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance;


        private int counter = 0;

        public SqlBooksModel()
        {
        }

        public string Create(string title)
        {
            string isbn = "ISBN-" + counter++;
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into books (isbn, title, pages, price) values (@isbn, @title, 0, 0.0)";
                command.Parameters.Add(new SqlParameter("@isbn", isbn));
                command.Parameters.Add(new SqlParameter("@title", title));
                command.ExecuteNonQuery();
            }
            return isbn;
        }

        public void DeleteByIsbn(string isbn)
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "delete from books where isbn = @isbn";
                command.Parameters.Add(new SqlParameter("@isbn", isbn));
                command.ExecuteNonQuery();
            }
        }

        public List<Book> FindAll()
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select * from books";
                var reader = command.ExecuteReader();
                List<Book> result = new List<Book>();
                while (reader.Read())
                {
                    result.Add(new Book((string)reader["isbn"], (string)reader["title"], (int)reader["pages"], (double)reader["price"],  false));
                }
                return result;
            }
        }
        public List<Book> FindByTitle(string title)
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select * from books where title = @title";
                command.Parameters.Add(new SqlParameter("@title", title));
                var reader = command.ExecuteReader();
                List<Book> result = new List<Book>();
                while (reader.Read())
                {
                    result.Add(new Book((string)reader["isbn"], (string)reader["title"], (int)reader["pages"], (double)reader["price"],  false));
                }
                return result;
            }
        }
        public List<Book> FindByPriceRange(double min, double max)
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select * from books where price > = @min and price < @max";
                command.Parameters.Add(new SqlParameter("@min", min));
                command.Parameters.Add(new SqlParameter("@max", max));
                var reader = command.ExecuteReader();
                List<Book> result = new List<Book>();
                while (reader.Read())
                {
                    result.Add(new Book((string)reader["isbn"], (string)reader["title"], (int)reader["pages"], (double)reader["price"],  false));
                }
                return result;
            }

        }

        public Book FindByIsbn(string isbn)
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select * from books where isbn = @isbn";
                command.Parameters.Add(new SqlParameter("@isbn", isbn));
                var reader = command.ExecuteReader();
                reader.Read();
                return new Book((string)reader["isbn"], (string)reader["title"], (int)reader["pages"], (double)reader["price"], false);
            }
        }

        public void Update(Book book)
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "update books set title=@title, pages=@pages, price=@price where isbn = @isbn";
                command.Parameters.Add(new SqlParameter("@isbn", book.Isbn));
                command.Parameters.Add(new SqlParameter("@title", book.Title));
                command.Parameters.Add(new SqlParameter("@pages", book.Pages));
                command.Parameters.Add(new SqlParameter("@price", book.Price));
                command.ExecuteNonQuery();
            }

        }
        public List<string> FindAllIsbns(){
             using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = sqlFactory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select isbn from books";
                var reader = command.ExecuteReader();
                List<string> result = new List<string>();
                while (reader.Read())
                {
                    result.Add((string)reader["isbn"]);
                }
                return result;
           }
       }
    }
}
