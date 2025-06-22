// Portfolio.Application.Repositories/ITagRepository.cs
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
        Task<Tag?> GetByNameAsync(string name);
    }
}
