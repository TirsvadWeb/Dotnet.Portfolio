using Portfolio.Core.Models;

namespace Portfolio.Core.Repository.IRepository;

public interface IGenreRepository
{
    public Task<Genre> CreateAsync(Genre obj);
    public Task<Genre> UpdateAsync(Genre obj);
    public Task<bool> DeleteAsync(int id);
    public Task<Genre> GetAsync(int id);
    public Task<IEnumerable<Genre>> GetAllAsync();
}
