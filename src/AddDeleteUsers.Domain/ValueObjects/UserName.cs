using AddDeleteUsers.Domain.Exceptions;

namespace AddDeleteUsers.Domain.ValueObjects;

public record UserName {

    public string Name { get; set; }

    public UserName(string name) 
        =>  Name = name ?? throw new EmptyUserNameException();

    public static implicit operator string(UserName value) 
        => value.Name;

    public static implicit operator UserName(string name) 
        => new(name);
}