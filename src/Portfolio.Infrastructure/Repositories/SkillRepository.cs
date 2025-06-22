using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="Skill"/> entities.
/// Provides CRUD operations for skills in the portfolio context.
/// </summary>
public class SkillRepository : BaseRepository<Skill>, ISkillRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SkillRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public SkillRepository(PortfolioDbContext ctx) : base(ctx) { }
}
