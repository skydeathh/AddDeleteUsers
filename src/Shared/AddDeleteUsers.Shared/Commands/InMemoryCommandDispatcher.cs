﻿using AddDeleteUsers.Shared.Abstractions.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace AddDeleteUsers.Shared.Commands;
public class InMemoryCommandDispatcher : ICommandDispatcher {
    private readonly IServiceProvider _serviceProvider;

    public InMemoryCommandDispatcher(IServiceProvider serviceProvider)
        => _serviceProvider = serviceProvider;

    public async Task DispatchAsync<TCommand>(TCommand command) where TCommand : class, ICommand {
        using var scope = _serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();

        await handler.HandleAsync(command);
    }
}