using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

public class WorkExperienceRepository : BaseRepository<WorkExperience>, IWorkExperienceRepository
{
    public WorkExperienceRepository(PortfolioDbContext ctx) : base(ctx) { }
}
