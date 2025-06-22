using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Repository implementation for managing <see cref="Person"/> entities.
/// Provides CRUD operations and custom queries for persons in the portfolio context.
/// </summary>
public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonRepository"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public PersonRepository(PortfolioDbContext ctx) : base(ctx) { }

    /// <summary>
    /// Asynchronously retrieves a person by their full name.
    /// </summary>
    /// <param name="fullName">The full name of the person.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the person if found; otherwise, <c>null</c>.
    /// </returns>
    public async Task<Person?> GetByFullNameAsync(string fullName)
    {
        return await _ctx.Persons
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.FullName == fullName);
    }

    /// <summary>
    /// Asynchronously retrieves a person by their unique identifier, including their projects and associated tags.
    /// </summary>
    /// <param name="id">The unique identifier of the person.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the person with related projects and tags if found; otherwise, <c>null</c>.
    /// </returns>
    public async Task<Person?> GetWithProjectsAsync(Guid id)
    {
        return await _ctx.Persons
            .Include(p => p.Projects)
            .ThenInclude(p => p.Tags)
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}
