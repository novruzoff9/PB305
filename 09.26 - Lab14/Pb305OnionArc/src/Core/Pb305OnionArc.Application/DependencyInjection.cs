using Microsoft.Extensions.DependencyInjection;
using Pb305OnionArc.Application.Common.Mappers;
using Pb305OnionArc.Application.Services.Concretes;

namespace Pb305OnionArc.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => cfg.AddProfile<AuthorProfiler>());
        services.AddScoped<IAuthorService, AuthorService>();
        return services;
    }
}
