// Portfolio.Application.Repositories/IProjectRepository.cs
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<IReadOnlyList<Project>> ListByPersonAsync(Guid personId);
    }
}
