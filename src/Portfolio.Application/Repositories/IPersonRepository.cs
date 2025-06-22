// Portfolio.Application.Repositories/IPersonRepository.cs
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person?> GetByFullNameAsync(string fullName);

        // New method with related projects eagerly loaded
        Task<Person?> GetWithProjectsAsync(Guid id);
    }
}
