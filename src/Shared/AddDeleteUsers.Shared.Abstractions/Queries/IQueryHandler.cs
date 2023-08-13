namespace AddDeleteUsers.Shared.Abstractions.Queries;
public interface ICommandHandler {
    Task HandleAsync<TCommand>(TCommand command) where TCommand : class, IQuery;
}