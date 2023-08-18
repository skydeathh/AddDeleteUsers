using AddDeleteUsers.Application.Exeptions;
using AddDeleteUsers.Domain.Repositories;
using AddDeleteUsers.Shared.Abstractions.Commands;

namespace AddDeleteUsers.Application.Commands.Handlers;

internal sealed class RemoveUserHandler : ICommandHandler<RemoveUser> {
    private readonly IUsersRepository _repository;

    public RemoveUserHandler(IUsersRepository repository)
        => _repository = repository;

    public async Task HandleAsync(RemoveUser command) {
        var user = await _repository.GetAsync(command.id);

        if (user is null)
            throw new UserNotFoundException();

        await _repository.DeleteAsync(user);
    }
}