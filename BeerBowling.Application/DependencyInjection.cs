using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BeerBowling.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetAssembly(typeof(DependencyInjection));
        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(assembly!));

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}