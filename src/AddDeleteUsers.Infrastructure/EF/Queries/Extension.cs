using AddDeleteUsers.Infrastructure.EF.Models;

namespace AddDeleteUsers.Infrastructure.EF.Queries {
    internal static class Extension {
        public static UserDto AsDto(this UserReadModel readModel)
            => new() {
                Id = readModel.Id,
                Name = readModel.Name,
                Surname = readModel.Surname,
                Gender = readModel.Gender
            };
    }
}