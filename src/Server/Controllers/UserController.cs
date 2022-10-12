using Domain.Repositories;
using Domain.Users;
using Microsoft.AspNetCore.Mvc;
using Shared.User;

namespace Server.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [Route("api/[controller]/")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;
        private readonly I
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public ActionResult<User> RegisterUser(UserDto user)
        {
            return NoContent();
        }



    }
}
