using AddDeleteUsers.Application.Exceptions;
using AddDeleteUsers.Domain.Repositories;
using AddDeleteUsers.Shared.Abstractions.Commands;
using AddDeleteUsers.Domain.Entities;

namespace AddDeleteUsers.Application.Commands.Handlers;

internal sealed class AddUserHandler : ICommandHandler<AddUser> {
    private readonly IUsersRepository _repository;

    public AddUserHandler(IUsersRepository repository) 
        => _repository = repository;

    public async Task HandleAsync(AddUser command) {
        var (id, name, surname, gender) = command;

        var user = _repository.GetAsync(id);
        if (user != null)
            throw new UserAleadyExistsException();

        var newUser = new User(id, name, surname, gender);
        await _repository.AddAsync(newUser);
    }
}