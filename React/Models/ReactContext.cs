using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace React.Models
{
    public class ReactContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Introduction> Introductions { get; set; }
        // public DbSet<FundamentalsOne> FundamentalsOnes { get; set; }
        // public DbSet<FundamentalsTwo> FundamentalsTwos { get; set; }
        // public DbSet<Redux> Reduxes { get; set; }
        // public DbSet<NoSQL> NoSQLs { get; set; }
        // public DbSet<Api> Apis { get; set; }
        public ReactContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseLazyLoadingProxies();
        }
    }
}