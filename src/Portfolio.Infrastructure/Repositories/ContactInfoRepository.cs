using Portfolio.Application.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Persistence;

namespace Portfolio.Infrastructure.Repositories;

public class ContactInfoRepository : BaseRepository<ContactInfo>, IContactInfoRepository
{
    public ContactInfoRepository(PortfolioDbContext ctx) : base(ctx) { }
}
