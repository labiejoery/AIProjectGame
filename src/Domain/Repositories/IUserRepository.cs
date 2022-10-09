using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        public User GetById(int id);
        public ICollection<User> GetAll();
        public void Add(User user);
        public void Update(User user);
        public void SaveChanges();
        public ICollection<User> GetAllPatiënts();
        public ICollection<User> GetAllLogopedisten();
        public ICollection<User> GetAllPatientsFromLogopedistById(int id);
    }
}
