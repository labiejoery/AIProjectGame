using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Shared.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        public Context _dbContext { get; set; }
        public DbSet<User> _users { get; set; }

        public UserService(Context dbContext)
        {
           _dbContext = dbContext;
            _users = dbContext.Users;
        }

        public async Task<UserResponse.Create> CreateAsync(UserRequest.Create request)
        {
            UserResponse.Create response = new UserResponse.Create();

            User userToBeCreated = new User(request.User.FirstName, request.User.LastName, request.User.Role);

            _users.Add(userToBeCreated);

            await _dbContext.SaveChangesAsync();
            response.CreatedUserId = userToBeCreated.Id;
            return response;

        }
    }
}
