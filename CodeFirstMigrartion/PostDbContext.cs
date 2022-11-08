using System.Data.Entity;

namespace CodeFirstMigrartion
{
    public class PostDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
