using Domain;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(string username);
    }
}