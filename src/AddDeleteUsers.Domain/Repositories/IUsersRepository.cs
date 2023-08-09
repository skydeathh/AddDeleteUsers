using AddDeleteUsers.Domain.Entities;
using AddDeleteUsers.Domain.ValueObjects;

namespace AddDeleteUsers.Domain.Repositories;

public interface IUsersRepository {
    Task<User> GetAsync(UserId id);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
}

