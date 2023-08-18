using AddDeleteUsers.Shared.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace AddDeleteUsers.Application;

public static class Extension {
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services.AddCommands();

        return services;
    }
}