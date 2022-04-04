using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace React.Models
{
    public class ReactContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Introduction> Introductions { get; set; }
        // public DbSet<Introduction> Introduction { get; set; }
        // public DbSet<Introduction> Introduction { get; set; }
        // public DbSet<Introduction> Introduction { get; set; }
        // public DbSet<Introduction> Introduction { get; set; }
        public ReactContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseLazyLoadingProxies();
        }
    }
}