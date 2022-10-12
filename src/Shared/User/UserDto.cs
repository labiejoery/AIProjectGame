using Domain.Users;

namespace Shared.User
{
    public class UserDto
    {
        public class Index
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public RoleEnum Role { get; set; }

        }

        public class Create
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public RoleEnum Role { get; set; }
        }
    }
}
