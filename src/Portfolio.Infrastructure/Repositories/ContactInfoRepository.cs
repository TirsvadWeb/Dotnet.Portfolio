using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="ContactInfo"/> entities.
/// Provides CRUD operations for contact information in the portfolio context.
/// </summary>
public class ContactInfoRepository : BaseRepository<ContactInfo>, IContactInfoRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactInfoRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public ContactInfoRepository(PortfolioDbContext ctx) : base(ctx) { }
}
