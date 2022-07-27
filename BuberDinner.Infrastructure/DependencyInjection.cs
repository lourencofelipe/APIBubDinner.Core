using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BuberDinner.Infrastructure;


namespace BuberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        //services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        // services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        // services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}
