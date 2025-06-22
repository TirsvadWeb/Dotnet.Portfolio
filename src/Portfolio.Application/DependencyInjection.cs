using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Mappings;

namespace Portfolio.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        return services;
    }
}
