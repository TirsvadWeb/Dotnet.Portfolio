using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

// EducationRepository.cs
public class EducationRepository : BaseRepository<Education>, IEducationRepository
{
    public EducationRepository(PortfolioDbContext ctx) : base(ctx) { }
}
