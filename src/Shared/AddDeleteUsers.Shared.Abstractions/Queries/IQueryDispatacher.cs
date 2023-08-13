namespace AddDeleteUsers.Shared.Abstractions.Queries;
public interface ICommandDispatchr {
    Task DispatchAsync<TCommand>(TCommand command) where TCommand : class, IQuery;
}