using AddDeleteUsers.Domain.Consts;
using AddDeleteUsers.Shared.Abstractions.Commands;

namespace AddDeleteUsers.Application.Commands;

public record AddUser(Guid id, string Name, string Surname, Gender Gender) : ICommand;