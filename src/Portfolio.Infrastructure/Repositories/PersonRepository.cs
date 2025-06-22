// Infrastructure/Repositories/PersonRepository.cs
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories
{
    // Fix for CS1520: Method must have a return type
    // The constructor name was incorrect. It should match the class name.

    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(PortfolioDbContext ctx) : base(ctx) { }

        public async Task<Person?> GetByFullNameAsync(string fullName)
        {
            return await _ctx.Persons
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.FullName == fullName);
        }

        public async Task<Person?> GetWithProjectsAsync(Guid id)
        {
            return await _ctx.Persons
                .Include(p => p.Projects)
                .ThenInclude(p => p.Tags)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
