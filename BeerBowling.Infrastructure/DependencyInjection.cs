using BeerBowling.Domain.IRepository;
using BeerBowling.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BeerBowling.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddScoped<IPlayerRepository, PlayerRepository>();
        
        // Scrutor
        services.Decorate<IPlayerRepository, CachedPlayerRepository>();

        return services;
    }
}

