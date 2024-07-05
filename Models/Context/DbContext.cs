using Microsoft.EntityFrameworkCore;
using prokeep.Models;


public class AppContext : DbContext
{

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {

    }

    public DbSet<Product> Product { get; set; }
}