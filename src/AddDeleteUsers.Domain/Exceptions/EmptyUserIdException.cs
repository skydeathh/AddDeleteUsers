using AddDeleteUsers.Shared.Abstractions.Exceptions;

namespace AddDeleteUsers.Domain.Exceptions;

internal class EmptyUserIdException : AddDeleteException {
    public EmptyUserIdException() : base(message: $"User's Id cannot be epmty.") {

    }
}