namespace AddDeleteUsers.Infrastructure.EF.Models;
    internal class UserReadModel {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Gender { get; set; }
}