using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.User
{
    public class UserRequest
    {

        public class Create
        {
            public UserDto.Create User { get; set; }
        }
    }
}
