using Microsoft.Extensions.DependencyInjection;

namespace Bibliotheque.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ILivreService, LivreService>();

            return services;
        }
    }
}
