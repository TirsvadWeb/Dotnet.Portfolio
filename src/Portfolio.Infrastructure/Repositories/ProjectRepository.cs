// ProjectRepository.cs
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;
public class ProjectRepository : BaseRepository<Project>, IProjectRepository
{
    public ProjectRepository(PortfolioDbContext ctx) : base(ctx) { }

    public async Task<IReadOnlyList<Project>> ListByPersonAsync(Guid personId)
    {
        return await _ctx.Projects
            .Where(p => p.PersonId == personId)
            .Include(p => p.Tags)
            .AsNoTracking()
            .ToListAsync();
    }
}
