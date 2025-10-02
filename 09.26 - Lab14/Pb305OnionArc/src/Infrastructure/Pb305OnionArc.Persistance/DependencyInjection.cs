using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pb305OnionArc.Application.Common.Interfaces;
using Pb305OnionArc.Persistance.Data;
using Pb305OnionArc.Persistance.Interceptors;

namespace Pb305OnionArc.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<SoftDeleteInterceptor>();

        services.AddDbContext<AppDbContext>(
            (sp, options) => options
                .UseSqlServer(configuration.GetConnectionString("default"))
                .AddInterceptors(
                    sp.GetRequiredService<SoftDeleteInterceptor>()));

        services.AddScoped<IAppDbContext, AppDbContext>();

        return services;
    }
}
