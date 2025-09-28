using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pb305OnionArc.Application.Common.Interfaces;
using Pb305OnionArc.Persistance.Data;

namespace Pb305OnionArc.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("default")));

        services.AddScoped<IAppDbContext, AppDbContext>();
        return services;
    }
}
