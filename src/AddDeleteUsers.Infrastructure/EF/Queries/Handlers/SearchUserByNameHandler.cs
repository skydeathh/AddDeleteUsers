using AddDeleteUsers.Application.Queries;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDeleteUsers.Infrastructure.EF.Queries.Handlers;
internal class SearchUserByNameHandler {
    private readonly DbSet<UserReadModel> _users;

    public SearchUserByNameHandler(DbSet<UserReadModel> users)
        => _users = users;

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