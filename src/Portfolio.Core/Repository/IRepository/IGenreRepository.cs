using Portfolio.Core.Models;

namespace Portfolio.Core.Repository.IRepository;

public interface IGenreRepository
{
    public Task<Genre> AddAsync(Genre obj);
    public Task<Genre> UpdateAsync(Genre obj);
    public Task<bool> DeleteAsync(Guid guid);
    public Task<Genre> GetAsync(Guid guid);
    public Task<IEnumerable<Genre>> GetAllAsync();
    public Task<bool> ExistsAsync(Guid guid);
}
