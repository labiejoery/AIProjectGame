using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.User
{
    public interface IUserService
    {
        Task<UserResponse.Create> CreateAsync(UserRequest.Create request);
    }
}
