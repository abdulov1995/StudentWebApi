using Microsoft.EntityFrameworkCore;

namespace StudentWebApi
{
    public class AppDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        protected  void Onconfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=StudentDB";
            optionsBuilder.UseNpgsql(connectionString);
        }

    }
}
