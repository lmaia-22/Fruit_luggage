using Domain;

namespace Infrastructure.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(string username);
    }
}