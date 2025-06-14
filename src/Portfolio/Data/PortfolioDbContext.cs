using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Models;

namespace Portfolio.Data;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options)
    {
    }

    public DbSet<Genre> Genre => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Genre>().HasData(
            new Genre { Guid = Guid.Parse("e3642c4e-db08-47fa-8757-5a62ada67edb"), Name = "Python" },
            new Genre { Guid = Guid.Parse("a5ab66c1-30d9-4773-8366-dad834af6bbd"), Name = "c#" },
            new Genre { Guid = Guid.Parse("0936dd59-5f27-4efd-b415-05f0bb817ee2"), Name = "Blazor" }
            );
    }
}
