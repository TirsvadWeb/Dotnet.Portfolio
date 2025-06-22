using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="Tag"/> entities.
/// Provides CRUD operations and custom queries for tags in the portfolio context.
/// </summary>
public class TagRepository : BaseRepository<Tag>, ITagRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TagRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public TagRepository(PortfolioDbContext ctx) : base(ctx) { }

    /// <summary>
    /// Asynchronously retrieves a tag by its name.
    /// </summary>
    /// <param name="name">The name of the tag.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the tag if found; otherwise, <c>null</c>.
    /// </returns>
    public async Task<Tag?> GetByNameAsync(string name)
    {
        return await _ctx.Tags
            .FirstOrDefaultAsync(t => t.Name == name);
    }
}
