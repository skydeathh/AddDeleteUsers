namespace AddDeleteUsers.Domain.Exceptions;
internal class EmptyUserSurnameException : Exception {
    public EmptyUserSurnameException() : base(message: $"User's surname cannot be epmty.") {

    }
}