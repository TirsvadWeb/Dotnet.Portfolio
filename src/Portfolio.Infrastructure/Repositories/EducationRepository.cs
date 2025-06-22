using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="Education"/> entities.
/// Provides CRUD operations for education records in the portfolio context.
/// </summary>
public class EducationRepository : BaseRepository<Education>, IEducationRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EducationRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public EducationRepository(PortfolioDbContext ctx) : base(ctx) { }
}
