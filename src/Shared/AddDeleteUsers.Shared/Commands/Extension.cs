using Microsoft.Extensions.DependencyInjection;
using AddDeleteUsers.Shared.Abstractions.Commands;
using System.Reflection;
using System.Linq;

namespace AddDeleteUsers.Shared.Commands;
public static class Extension {
    public static IServiceCollection AddComands(this IServiceCollection services) {
        var assembly = Assembly.GetCallingAssembly();

        services.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();

        services
            .Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }
}