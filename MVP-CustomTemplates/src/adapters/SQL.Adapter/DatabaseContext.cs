using Domain;
using Microsoft.EntityFrameworkCore;

namespace SQL.Adapter
{
    public class DatabaseContext : DbContext 
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Product> Table => Set<Product>();
    }

}