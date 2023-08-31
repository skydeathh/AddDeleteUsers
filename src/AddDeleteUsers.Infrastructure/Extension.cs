using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AddDeleteUsers.Shared.Queries;
using AddDeleteUsers.Infrastructure.EF;
using AddDeleteUsers.Shared.Abstractions.Commands;
using AddDeleteUsers.Infrastructure.Logging;

namespace AddDeleteUsers.Infrastructure;

public static class Extension {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {

        services.AddPostgres(configuration);
        services.AddQueries();

        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));
        return services;
    }
}