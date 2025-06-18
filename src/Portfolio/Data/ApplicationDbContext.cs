using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Core.Models.Genre> Genre => Set<Core.Models.Genre>();
    public DbSet<Core.Models.PortfolioItem> PortfolioItem => Set<Core.Models.PortfolioItem>();
    public DbSet<Core.Models.PortfolioPerson> DeveloperInfo => Set<Core.Models.PortfolioPerson>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Core.Models.Genre>().HasData(
            new Core.Models.Genre { Id = Guid.Parse("e3642c4e-db08-47fa-8757-5a62ada67edb"), Name = "Python" },
            new Core.Models.Genre { Id = Guid.Parse("a5ab66c1-30d9-4773-8366-dad834af6bbd"), Name = "C#" },
            new Core.Models.Genre { Id = Guid.Parse("0936dd59-5f27-4efd-b415-05f0bb817ee2"), Name = "Blazor" }
            );

        builder.Entity<Core.Models.PortfolioItem>().HasData(
            new Core.Models.PortfolioItem
            {
                Id = Guid.Parse("0577fbae-b2c8-4807-bb32-3c6f3e80af29"),
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

        builder.Entity<Core.Models.PortfolioPerson>().HasData(
            new Core.Models.PortfolioPerson
            {
                Id = Guid.Parse("f1fbbdf6-af0e-43a8-935e-7d59e091a388"),
                Name = "Jens Tirsvad Nielsen",
                Description = "Software Engineer Skilled in C#, and Python, with a strong foundation in web development and backend systems." +
                " Experienced in configuring and optimizing web servers, ensuring efficient deployment and performance." +
                " Proficient in Linux and Windows operating systems, managing environments for seamless software execution."
            }
            );

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "875a25fd-216e-48c1-bb72-99559cbd1bed",
                UserName = "jenstirsvad@gmail.com",
                NormalizedUserName = "JENSTIRSVAD@GMAIL.COM",
                Email = "jenstirsvad@gmail.com",
                NormalizedEmail = "JENSTIRSVAD@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEAXfEmM1tC+eQ69Lf2KbruY7dC/o/aA0bVrguuazN+CkIq8sqMivBeoWyZ7f/2sYUg==",
                SecurityStamp = "NEVEOGGL4VPHGJ5M5SGEKJVCARFYRFYQ",
                ConcurrencyStamp = "40bf735b-6e37-44d0-a6e5-4dd8d58e990b",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = true
            }
            );
    }

}
