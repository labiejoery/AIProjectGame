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
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public ActionResult<User> RegisterUser(UserDto user)
        {

            _userRepository.Add()

            return NoContent();
        }

    }
}
