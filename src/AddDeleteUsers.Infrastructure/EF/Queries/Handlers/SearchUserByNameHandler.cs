using AddDeleteUsers.Application.Queries;
using AddDeleteUsers.Infrastructure.EF.Models;
using AddDeleteUsers.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;
using AddDeleteUsers.Application.DTO;
using AddDeleteUsers.Infrastructure.EF.Contexts;

namespace AddDeleteUsers.Infrastructure.EF.Queries.Handlers;
internal class SearchUserByNameHandler : IQueryHandler<SearchUserByName, IEnumerable<UserDto>> {
    private readonly DbSet<UserReadModel> _users;
    public SearchUserByNameHandler(ReadDbContext context)
        => _users = context.Users;

    public async Task<IEnumerable<UserDto>> HandleAsync(SearchUserByName query) {
        var dbQuery = _users.AsQueryable();

        if (query.Name is not null) {
            dbQuery = dbQuery
                .Where(u => Microsoft.EntityFrameworkCore.EF.Functions.Like(u.Name, $"%{query.Name}%"));
        }

        return await dbQuery
            .Select(u => u.AsDto())
            .AsNoTracking()
            .ToListAsync();
    }
}