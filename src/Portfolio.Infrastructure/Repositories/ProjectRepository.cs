using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="Project"/> entities.
/// Provides CRUD operations and custom queries for projects in the portfolio context.
/// </summary>
public class ProjectRepository : BaseRepository<Project>, IProjectRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public ProjectRepository(PortfolioDbContext ctx) : base(ctx) { }

    /// <summary>
    /// Asynchronously retrieves all projects associated with a specific person, including their tags.
    /// </summary>
    /// <param name="personId">The unique identifier of the person.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a read-only list of projects for the specified person.
    /// </returns>
    public async Task<IReadOnlyList<Project>> ListByPersonAsync(Guid personId)
    {
        return await _ctx.Projects
            .Where(p => p.PersonId == personId)
            .Include(p => p.Tags)
            .AsNoTracking()
            .ToListAsync();
    }
}
