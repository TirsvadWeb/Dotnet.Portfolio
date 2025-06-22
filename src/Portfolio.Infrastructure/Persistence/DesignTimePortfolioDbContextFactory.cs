using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Portfolio.Infrastructure.Persistence;

public class DesignTimePortfolioDbContextFactory : IDesignTimeDbContextFactory<PortfolioDbContext>
{
    public PortfolioDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PortfolioDbContext>();
        // Use your actual connection string here
        optionsBuilder.UseSqlite("Data Source=data/portfolio.db");

        return new PortfolioDbContext(optionsBuilder.Options);
    }
}