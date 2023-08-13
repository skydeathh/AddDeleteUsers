namespace AddDeleteUsers.Application.Services;
    public interface IUserReadServics {
    Task<bool> IsExist(Guid id);
}