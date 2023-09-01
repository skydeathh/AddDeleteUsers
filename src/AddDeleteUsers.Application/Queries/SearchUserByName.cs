using AddDeleteUsers.Shared.Abstractions.Queries;
using AddDeleteUsers.Application.DTO;

namespace AddDeleteUsers.Application.Queries;

public class SearchUserByName : IQuery<IEnumerable<UserDto>> {
    public string Name { get; set; }
}