using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BooksWarehouseTests
{
    public class SqlBooksModelTest {
        private readonly Xunit.Abstractions.ITestOutputHelper _testOutputHelper;

        public SqlBooksModelTest(Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void testDb()
        {
            DbProviderFactory sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance;
            var connection = sqlFactory.CreateConnection();
            connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection.Open();
            System.Console.WriteLine(connection.Database);
            DbCommand command = sqlFactory.CreateCommand();
            command.Connection = connection;
            command.CommandText = "select * from messages";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                _testOutputHelper.WriteLine(reader["message"].ToString());
            }

        }
    }
}
