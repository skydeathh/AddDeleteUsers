using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Domain.Repositories;
using AddDeleteUsers.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using AddDeleteUsers.Infrastructure.EF.Contexts;

namespace AddDeleteUsers.Infrastructure.EF.Repositories;

internal class PostgresAddDeleteUsersRepository : IUsersRepository {
    private readonly DbSet<User> _users;
    private readonly WriteDbContext _writeDbContext;

    public PostgresAddDeleteUsersRepository(WriteDbContext writeDbContext) {
        _users = writeDbContext.Users;
        _writeDbContext = writeDbContext;
    }

    public async Task AddAsync(User user) {
        await _users.AddAsync(user);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user) {
        _users.Remove(user);
        await _writeDbContext.SaveChangesAsync();
    }

    public Task<User> GetAsync(UserId id) 
        => _users.FirstOrDefaultAsync(x => x.Id == id);
            

    public async Task UpdateAsync(User user) {
        _users.Update(user);
        await _writeDbContext.SaveChangesAsync();
    }
}