namespace AddDeleteUsers.Domain.Exceptions;

internal class EmptyUserIdException : Exception {
    public EmptyUserIdException() : base(message: $"User's Id cannot be epmty.") {

    }
}