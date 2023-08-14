using AddDeleteUsers.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
