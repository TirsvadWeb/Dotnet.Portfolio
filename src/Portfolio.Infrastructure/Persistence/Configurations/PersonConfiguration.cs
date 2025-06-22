using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Entities;

namespace Portfolio.Infrastructure.Persistence.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.FullName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Bio)
                   .HasMaxLength(1000);

            builder.Property(p => p.ProfileImage)
                   .HasMaxLength(300);

            builder.Property(p => p.SocialBannerImage)
                   .HasMaxLength(300);

            builder.HasMany(p => p.Projects)
                   .WithOne(p => p.Author)
                   .HasForeignKey(p => p.PersonId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
