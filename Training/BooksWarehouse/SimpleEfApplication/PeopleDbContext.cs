using Microsoft.EntityFrameworkCore;
namespace Javacream.Training.Ef
{
    public class PeopleDbContext : DbContext
    {
        private readonly string connectionString = "Data Source=h2908727.stratoserver.net;Initial Catalog=publishing;User ID=sa;Password=javacream123!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}