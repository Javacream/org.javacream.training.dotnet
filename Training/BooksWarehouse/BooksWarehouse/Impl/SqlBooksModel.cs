using Javacream.BooksWarehouse.Api;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace Javacream.BooksWarehouse.Impl
{
    public class SqlBooksModel : BooksModel
    {
        private readonly string connectionString = "Data Source=h2908727.stratoserver.net;Initial Catalog=publishing;User ID=sa;Password=javacream123!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DbProviderFactory sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance;


        private Random random = new Random();

        public SqlBooksModel()
        {
        }

        public string Create(string title)
        {
            string isbn = "ISBN" + random.Next();
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
        public Book FindByTitle(string title)
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
                reader.Read();
                return new Book((string)reader["isbn"], (string)reader["title"], (int)reader["pages"], (double)reader["price"], false);
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