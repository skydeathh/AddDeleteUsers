namespace AddDeleteUsers.Application.Services;
    public interface IUsersReadServics {
    Task<bool> IsExist(Guid id);
}