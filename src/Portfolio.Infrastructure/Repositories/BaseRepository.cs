using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

/// <summary>
/// Provides a generic repository implementation for basic CRUD operations on entities.
/// </summary>
/// <typeparam name="T">The type of entity, which must inherit from <see cref="BaseEntity"/>.</typeparam>
public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    /// <summary>
    /// The database context used for data access.
    /// </summary>
    protected readonly PortfolioDbContext _ctx;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
    /// </summary>
    /// <param name="ctx">The <see cref="PortfolioDbContext"/> to use for data access.</param>
    public BaseRepository(PortfolioDbContext ctx)
    {
        _ctx = ctx;
    }

    /// <summary>
    /// Asynchronously adds a new entity to the repository and saves changes.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public async Task AddAsync(T entity)
    {
        await _ctx.Set<T>().AddAsync(entity);
        await _ctx.SaveChangesAsync();
    }

    /// <summary>
    /// Asynchronously deletes an entity from the repository and saves changes.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public async Task DeleteAsync(T entity)
    {
        _ctx.Set<T>().Remove(entity);
        await _ctx.SaveChangesAsync();
    }

    /// <summary>
    /// Asynchronously retrieves an entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, <c>null</c>.
    /// </returns>
    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _ctx.Set<T>().FindAsync(id);
    }

    /// <summary>
    /// Asynchronously retrieves all entities of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a read-only list of entities.
    /// </returns>
    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _ctx.Set<T>().AsNoTracking().ToListAsync();
    }

    /// <summary>
    /// Asynchronously updates an existing entity in the repository and saves changes.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public async Task UpdateAsync(T entity)
    {
        _ctx.Set<T>().Update(entity);
        await _ctx.SaveChangesAsync();
    }
}
