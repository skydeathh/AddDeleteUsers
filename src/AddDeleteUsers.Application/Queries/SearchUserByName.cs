using AddDeleteUsers.Shared.Abstractions.Queries;

namespace AddDeleteUsers.Application.Queries;

public class SearchUserByName : IQuery<UserDto> {
    public string Name { get; set; }
}