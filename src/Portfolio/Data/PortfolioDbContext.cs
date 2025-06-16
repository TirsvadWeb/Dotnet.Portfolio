using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options)
    {
    }

    public DbSet<Core.Models.Genre> Genre => Set<Core.Models.Genre>();
    public DbSet<Core.Models.PortfolioItem> PortfolioItem => Set<Core.Models.PortfolioItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Core.Models.Genre>().HasData(
            new Core.Models.Genre { Guid = Guid.Parse("e3642c4e-db08-47fa-8757-5a62ada67edb"), Name = "Python" },
            new Core.Models.Genre { Guid = Guid.Parse("a5ab66c1-30d9-4773-8366-dad834af6bbd"), Name = "C#" },
            new Core.Models.Genre { Guid = Guid.Parse("0936dd59-5f27-4efd-b415-05f0bb817ee2"), Name = "Blazor" }
            );

        builder.Entity<Core.Models.PortfolioItem>().HasData(
            new Core.Models.PortfolioItem
            {
                Guid = Guid.Parse("0577fbae-b2c8-4807-bb32-3c6f3e80af29"),
                Name = "Portfolio Web application",
                Description = "A modern Blazor WebAssembly application for showcasing software projects and skills." +
                " Features include interactive project listings, technology tagging, and direct source code links." +
                " Designed for developers to present their work in a clean, responsive, and easily extensible format.",
                SourceLink = "https://portfolio.tirsvad.dk/",
                GenreTags = [
                    Guid.Parse("a5ab66c1-30d9-4773-8366-dad834af6bbd"),
                    Guid.Parse("0936dd59-5f27-4efd-b415-05f0bb817ee2")
                    ]
            }
            );
    }
}
