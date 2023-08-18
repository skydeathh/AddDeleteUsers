using AddDeleteUsers.Shared.Abstractions.Queries;

namespace AddDeleteUsers.Application.Queries;
public class GetUser : IQuery<UserDto> {
    public Guid Id { get; set; }
}