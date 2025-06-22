// SkillRepository.cs
using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

public class SkillRepository : BaseRepository<Skill>, ISkillRepository
{
    public SkillRepository(PortfolioDbContext ctx) : base(ctx) { }
}
