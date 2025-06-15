using Portfolio.Core.Models;

namespace Portfolio.Core.Repository.IRepository;

public interface IPortfolioItemRepository
{
    public Task<PortfolioItem> AddAsync(PortfolioItem obj);
    public Task<PortfolioItem> UpdateAsync(PortfolioItem obj);
    public Task<bool> DeleteAsync(Guid guid);
    public Task<PortfolioItem> GetAsync(Guid guid);
    public Task<IEnumerable<PortfolioItem>> GetAllAsync();
    public Task<bool> ExistsAsync(Guid guid);
}
