using AddDeleteUsers.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AddDeleteUsers.Shared;
public static class Extension {
    public static IServiceCollection AddShared(this IServiceCollection services) {
        services.AddHostedService<AppInitializer>();
        return services;
    }
}