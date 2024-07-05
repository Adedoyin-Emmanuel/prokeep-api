using Microsoft.EntityFrameworkCore;
using prokeep.Models;


public class AppContext : DbContext
{

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {

    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Product>().Property(p => p.CreatedAt).HasDefaultValueSql("getdate()");
    // }

    public DbSet<Product> Product { get; set; }
}