namespace AddDeleteUsers.Domain.Exceptions;

internal class EmptyUserNameException : Exception {
    public EmptyUserNameException() : base(message: $"User's name cannot be epmty.") {

    }
}