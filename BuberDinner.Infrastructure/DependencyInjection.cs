using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        // services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        // services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        // services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

      return services;
    }
}

