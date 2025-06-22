using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

public class TagRepository : BaseRepository<Tag>, ITagRepository
{
    public TagRepository(PortfolioDbContext ctx) : base(ctx) { }

    public async Task<Tag?> GetByNameAsync(string name)
    {
        return await _ctx.Tags
            .FirstOrDefaultAsync(t => t.Name == name);
    }
}
