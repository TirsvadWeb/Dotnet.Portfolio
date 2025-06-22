using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly PortfolioDbContext _ctx;

    public BaseRepository(PortfolioDbContext ctx)
    {
        _ctx = ctx;
    }

    public async Task AddAsync(T entity)
    {
        await _ctx.Set<T>().AddAsync(entity);
        await _ctx.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _ctx.Set<T>().Remove(entity);
        await _ctx.SaveChangesAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _ctx.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _ctx.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _ctx.Set<T>().Update(entity);
        await _ctx.SaveChangesAsync();
    }
}
