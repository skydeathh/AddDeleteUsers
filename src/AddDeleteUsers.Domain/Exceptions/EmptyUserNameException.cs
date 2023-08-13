using AddDeleteUsers.Shared.Abstractions.Exceptions;

namespace AddDeleteUsers.Domain.Exceptions;

internal class EmptyUserNameException : AddDeleteException {
    public EmptyUserNameException() : base(message: $"User's name cannot be epmty.") {

    }
}