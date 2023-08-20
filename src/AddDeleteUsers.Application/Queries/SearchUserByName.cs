using AddDeleteUsers.Shared.Abstractions.Queries;

namespace AddDeleteUsers.Application.Queries;

public class SearchUserByName : IQuery<IEnumerable<UserDto>> {
    public string Name { get; set; }
}