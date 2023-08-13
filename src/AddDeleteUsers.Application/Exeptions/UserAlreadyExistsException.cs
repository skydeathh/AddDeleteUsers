using AddDeleteUsers.Shared.Abstractions.Exceptions;

namespace AddDeleteUsers.Application.Exceptions {
    internal class UserAleadyExistsException : AddDeleteException {
        public UserAleadyExistsException() : base(message: $"User already exists in database.") {

        }
    }
}
