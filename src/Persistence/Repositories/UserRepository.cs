using Domain.Repositories;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly Context _context;
        private readonly DbSet<User> _users;

        public UserRepository(Context dbContext)
        {
            _context = dbContext;
            _users = dbContext.Users;
        }

        public void Add(User user) => _users.Add(user);

        public ICollection<User> GetAll() => _users.ToList();

        public ICollection<User> GetAllLogopedisten() => _users.Where(user => user.Role == RoleEnum.Logopedist).ToList();

        public ICollection<User> GetAllPatientsFromLogopedistById(int id) => _users.Where(user => user.Id == id).SingleOrDefault().Patienten.ToList();

        public ICollection<User> GetAllPatiënts() => _users.Where(user => user.Role == RoleEnum.Patiënt).ToList();

        public User GetById(int id) => _users.SingleOrDefault(user => user.Id == id);

        public void SaveChanges() => _context.SaveChanges();

        public void Update(User user) => _users.Update(user);
    }
}
