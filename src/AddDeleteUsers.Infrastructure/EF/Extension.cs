﻿using AddDeleteUsers.Domain.Repositories;
using AddDeleteUsers.Infrastructure.EF.Contexts;
using AddDeleteUsers.Infrastructure.EF.Options;
using AddDeleteUsers.Infrastructure.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AddDeleteUsers.Shared.Options;
using AddDeleteUsers.Application.Services;
using AddDeleteUsers.Infrastructure.EF.Services;

namespace AddDeleteUsers.Infrastructure.EF;

internal static class Extension {
    public static IServiceCollection AddPostgres(this IServiceCollection services, 
        IConfiguration configuration) {

        services.AddScoped<IUsersRepository, PostgresAddDeleteUsersRepository>();
        services.AddScoped<IUsersReadServics, PostgresAddDeleteUsersReadService>();

        var options = configuration.GetOptions<PostgresOptions>("Postgres");

        services.AddDbContext<ReadDbContext>(ctx
            => ctx.UseNpgsql(options.ConnectionString));

        services.AddDbContext<WriteDbContext>(ctx
            => ctx.UseNpgsql(options.ConnectionString));

        return services;

    }
}