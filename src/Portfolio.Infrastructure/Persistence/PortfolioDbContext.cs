using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Domain.Entities;
using Portfolio.Domain.ValueObjects;
using Portfolio.Infrastructure.Persistence.Configurations;

namespace Portfolio.Infrastructure.Persistence
{
    public class PortfolioDbContext : IdentityDbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; } = default!;
        public DbSet<Project> Projects { get; set; } = default!;
        public DbSet<Skill> Skills { get; set; } = default!;
        public DbSet<Education> Educations { get; set; } = default!;
        public DbSet<WorkExperience> WorkExperiences { get; set; } = default!;
        public DbSet<ContactInfo> ContactInfos { get; set; } = default!;
        public DbSet<Tag> Tags { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            // any fluent config, e.g.:  
            // modelBuilder.Entity<Person>().HasIndex(p => p.FullName).IsUnique();  

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
}
