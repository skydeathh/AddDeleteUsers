using AddDeleteUsers.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDeleteUsers.Application.Exeptions {
    internal class UserNotFoundException : AddDeleteException {
        public UserNotFoundException() : base(message: $"User already exists in database.") {

        }
    }
}