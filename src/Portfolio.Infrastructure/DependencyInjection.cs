using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Repositories;
using Portfolio.Infrastructure.Persistence;
using Portfolio.Infrastructure.Repositories;

namespace Portfolio.Infrastructure;

/// <summary>
/// Provides extension methods for registering infrastructure services in the dependency injection container.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds infrastructure services, including the database context and repositories, to the specified <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The service collection to add services to.</param>
    /// <param name="configuration">The application configuration containing connection strings and other settings.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration
        )
    {
        // 1) DbContext
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<PortfolioDbContext>(options =>
            options.UseSqlite(connectionString));

        services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
        services.AddScoped<IEducationRepository, EducationRepository>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();

        return services;
    }
}
