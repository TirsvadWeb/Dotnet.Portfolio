using Portfolio.Domain.Entities;

namespace Portfolio.Application.Repositories;

/// <summary>
/// Defines a generic repository interface for basic CRUD operations on entities.
/// </summary>
/// <typeparam name="T">The type of entity, which must inherit from <see cref="BaseEntity"/>.</typeparam>
public interface IRepository<T> where T : BaseEntity
{
    /// <summary>
    /// Asynchronously retrieves an entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, <c>null</c>.
    /// </returns>
    Task<T?> GetByIdAsync(Guid id);

    /// <summary>
    /// Asynchronously retrieves all entities of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a read-only list of entities.
    /// </returns>
    Task<IReadOnlyList<T>> ListAllAsync();

    /// <summary>
    /// Asynchronously adds a new entity to the repository.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task AddAsync(T entity);

    /// <summary>
    /// Asynchronously updates an existing entity in the repository.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task UpdateAsync(T entity);

    /// <summary>
    /// Asynchronously deletes an entity from the repository.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DeleteAsync(T entity);
}
