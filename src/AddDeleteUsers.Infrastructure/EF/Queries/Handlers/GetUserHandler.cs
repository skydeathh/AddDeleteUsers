using AddDeleteUsers.Application.Queries;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDeleteUsers.Infrastructure.EF.Queries.Handlers;
internal sealed class GetUserHandler {
    private readonly DbSet<UserReadModel> _users;

    public GetUserHandler(DbSet<UserReadModel> users)
        => _users = users;

    public Task<UserDto> HandleAsync(GetUser query) 
        => _users
        .Where(u => u.Id == query.Id)
        .Select(u => u.AsDto())
        .AsNoTracking()
        .SingleOrDefaultAsync();
}

