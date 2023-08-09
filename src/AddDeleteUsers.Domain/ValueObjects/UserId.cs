using AddDeleteUsers.Domain.Exceptions;

namespace AddDeleteUsers.Domain.ValueObjects;
public record UserId {
    public Guid Id { get; }

    public UserId(Guid id) {
        if (id == Guid.Empty) 
            throw new EmptyUserIdException();

        Id = id;
    }

    public static implicit operator Guid(UserId id)
        => id.Id;

    public static implicit operator UserId(Guid id)
        => new(id);
}