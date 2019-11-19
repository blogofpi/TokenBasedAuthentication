using Microsoft.EntityFrameworkCore;

namespace TokenBasedAuth.Data
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
    }
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
       public DbSet<User> Users { get; set; }
    }
}
