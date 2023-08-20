using AddDeleteUsers.Domain.Consts;

public class UserDto {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
}