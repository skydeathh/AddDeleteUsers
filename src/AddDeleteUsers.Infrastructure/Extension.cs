using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AddDeleteUsers.Shared.Queries;
using AddDeleteUsers.Infrastructure.EF;


namespace AddDeleteUsers.Infrastructure;

public static class Extension {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {

        services.AddPostgres(configuration);
        services.AddQueries();

        return services;
    }
}
