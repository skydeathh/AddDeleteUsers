using AddDeleteUsers.Domain.Consts;

namespace AddDeleteUsers.Application.DTO;

public class UserDto {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
}