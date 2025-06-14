using Portfolio.Core.Models;

namespace Portfolio.Repository.IRepository;

public interface IGenreRepository
{
    public Task<Genre> AddAsync(Genre obj);
    public Task<Genre> UpdateAsync(Genre obj);
    public Task<bool> DeleteAsync(Guid id);
    public Task<Genre> GetAsync(Guid id);
    public Task<IEnumerable<Genre>> GetAllAsync();
    public Task<bool> ExistsAsync(Guid guid);
}
