using AddDeleteUsers.Shared.Abstractions.Commands;

namespace AddDeleteUsers.Application.Commands;

public record RemoveUser(Guid id) : ICommand;