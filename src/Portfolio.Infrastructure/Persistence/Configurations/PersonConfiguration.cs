using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Entities;

namespace Portfolio.Infrastructure.Persistence.Configurations;

/// <summary>
/// Configures the persistence mapping for the <see cref="Person"/> entity.
/// </summary>
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="Person"/>.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        // Set the table name
        builder.ToTable("Persons");

        // Configure the primary key
        builder.HasKey(p => p.Id);

        // Configure properties
        builder.Property(p => p.FullName)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(p => p.Bio)
               .HasMaxLength(1000);

        builder.Property(p => p.ProfileImage)
               .HasMaxLength(300);

        builder.Property(p => p.SocialBannerImage)
               .HasMaxLength(300);

        // Configure relationships
        builder.HasMany(p => p.Projects)
               .WithOne(p => p.Author)
               .HasForeignKey(p => p.PersonId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
