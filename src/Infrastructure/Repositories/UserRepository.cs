using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository, IRepository<User>
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
        public User Get(int userId)
        {
            return _context.Users.SingleOrDefault(c => c.Id == userId);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
        }

        public void Delete(int userId)
        {
            _context.Users.Remove(Get(userId));
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
        }

        public User Get(string username)
        {
            return _context.Users.SingleOrDefault(c => c.Username == username);
        }
    }
}
