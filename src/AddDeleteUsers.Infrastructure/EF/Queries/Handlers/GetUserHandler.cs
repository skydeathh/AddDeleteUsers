using AddDeleteUsers.Application.Queries;
using AddDeleteUsers.Infrastructure.EF.Models;
using AddDeleteUsers.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;
using AddDeleteUsers.Application.DTO;
using AddDeleteUsers.Infrastructure.EF.Contexts;

namespace AddDeleteUsers.Infrastructure.EF.Queries.Handlers;
internal sealed class GetUserHandler : IQueryHandler<GetUser, UserDto> {
    private readonly DbSet<UserReadModel> _users;

    public GetUserHandler(ReadDbContext context)
        => _users = context.Users;

    public Task<UserDto> HandleAsync(GetUser query) 
        => _users
        .Where(u => u.Id == query.Id)
        .Select(u => u.AsDto())
        .AsNoTracking()
        .SingleOrDefaultAsync();

}