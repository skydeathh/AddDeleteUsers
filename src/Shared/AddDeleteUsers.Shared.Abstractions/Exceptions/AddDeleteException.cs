namespace AddDeleteUsers.Shared.Abstractions.Exceptions;
public abstract class AddDeleteException : Exception {
    protected AddDeleteException(string message) : base(message) {
    }
}