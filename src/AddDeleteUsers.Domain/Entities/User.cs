using AddDeleteUsers.Domain.Consts;
using AddDeleteUsers.Domain.ValueObjects;

namespace AddDeleteUsers.Domain.Entities;

public sealed record User {
    public UserId Id { get; private set; }
    private UserName _userName;
    private UserSurname _userSurname;
    private Gender _gender;

    public User(UserId id, UserName userName, UserSurname userSurname, Gender gender) {
        Id = id;
        _userName = userName;
        _userSurname = userSurname;
        _gender = gender;
    }
}