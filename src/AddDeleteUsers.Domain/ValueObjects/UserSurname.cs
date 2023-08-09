using AddDeleteUsers.Domain.Exceptions;

namespace AddDeleteUsers.Domain.ValueObjects;

public record UserSurname {
    public string Surname { get; set; }

    public UserSurname(string surname)
        => Surname = surname ?? throw new EmptyUserSurnameException();

    public static implicit operator string(UserSurname value)
        => value.Surname;

    public static implicit operator UserSurname(string surname)
        => new(surname);
}