using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Domain.Entities;
using Portfolio.Domain.ValueObjects;
using Portfolio.Infrastructure.Persistence.Configurations;

namespace Portfolio.Infrastructure.Persistence;

/// <summary>
/// Represents the Entity Framework Core database context for the portfolio application.
/// Manages entity sets and configuration for persistence.
/// </summary>
public class PortfolioDbContext : IdentityDbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PortfolioDbContext"/> class.
    /// </summary>
    /// <param name="options">The options to be used by a <see cref="DbContext"/>.</param>
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the persons in the portfolio.
    /// </summary>
    public DbSet<Person> Persons { get; set; } = default!;

    /// <summary>
    /// Gets or sets the projects in the portfolio.
    /// </summary>
    public DbSet<Project> Projects { get; set; } = default!;

    /// <summary>
    /// Gets or sets the skills in the portfolio.
    /// </summary>
    public DbSet<Skill> Skills { get; set; } = default!;

    /// <summary>
    /// Gets or sets the education records in the portfolio.
    /// </summary>
    public DbSet<Education> Educations { get; set; } = default!;

    /// <summary>
    /// Gets or sets the work experiences in the portfolio.
    /// </summary>
    public DbSet<WorkExperience> WorkExperiences { get; set; } = default!;

    /// <summary>
    /// Gets or sets the contact information entries in the portfolio.
    /// </summary>
    public DbSet<ContactInfo> ContactInfos { get; set; } = default!;

    /// <summary>
    /// Gets or sets the tags for categorizing portfolio items.
    /// </summary>
    public DbSet<Tag> Tags { get; set; } = default!;

    /// <summary>
    /// Configures the entity mappings and relationships for the model.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply entity configurations
        modelBuilder.ApplyConfiguration(new PersonConfiguration());

        // Example: Add unique index on FullName if needed
        // modelBuilder.Entity<Person>().HasIndex(p => p.FullName).IsUnique();  

        // Configure value conversion for UriString value object
        var uriStringConverter = new ValueConverter<UriString?, string?>(
            v => v == null ? null : v.Value,
            v => v == null ? null : new UriString(v)
        );

        modelBuilder.Entity<Project>()
            .Property(p => p.LiveUrl)
            .HasConversion(uriStringConverter);

        modelBuilder.Entity<Project>()
            .Property(p => p.RepoUrl)
            .HasConversion(uriStringConverter);
    }
}
