using Domain;

namespace Infrastructure.Repositories
{
    public interface IBoxStorageRepository : IRepository<BoxStorage>
    {
        void Delete(int boxStorageId);
    }
}
