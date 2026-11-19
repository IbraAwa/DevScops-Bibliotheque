using Bibliotheque.Application.Repositories;
using Bibliotheque.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliotheque.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ILivreRepository, LivreRepository>();
        services.AddScoped<IMangaRepository, MangaRepository>();

        return services;
    }
}
