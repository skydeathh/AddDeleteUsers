using AddDeleteUsers.Shared.Abstractions.Exceptions;

namespace AddDeleteUsers.Domain.Exceptions;

internal class EmptyUserSurnameException : AddDeleteException {
    public EmptyUserSurnameException() : base(message: $"User's surname cannot be epmty.") {

    }
}