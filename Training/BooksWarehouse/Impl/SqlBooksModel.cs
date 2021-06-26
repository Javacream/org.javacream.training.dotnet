using BooksWarehouse.Api;
using BooksWarehouse.Api.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BooksWarehouse.Impl
{
    public class SqlBooksModel : BooksModel
    {

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
                connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
                connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
                connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

        public Book FindByIsbn(string isbn)
        {
            using (var connection = sqlFactory.CreateConnection())
            {
                connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
                connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
    }
}
