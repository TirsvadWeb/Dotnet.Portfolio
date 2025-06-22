using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="WorkExperience"/> entities.
/// Provides CRUD operations for work experience records in the portfolio context.
/// </summary>
public class WorkExperienceRepository : BaseRepository<WorkExperience>, IWorkExperienceRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkExperienceRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public WorkExperienceRepository(PortfolioDbContext ctx) : base(ctx) { }
}
