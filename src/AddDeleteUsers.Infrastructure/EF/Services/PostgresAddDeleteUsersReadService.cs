using AddDeleteUsers.Application.Services;
using AddDeleteUsers.Infrastructure.EF.Contexts;
using AddDeleteUsers.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDeleteUsers.Infrastructure.EF.Services;
internal sealed class PostgresAddDeleteUsersReadService : IUsersReadServics {
    private readonly DbSet<UserReadModel> _users;
    public PostgresAddDeleteUsersReadService(ReadDbContext context)
        => _users = context.Users;
    public Task<bool> IsExist(Guid id)
        => _users.AnyAsync(u => u.Id == id);
}