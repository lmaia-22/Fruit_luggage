using Domain;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public interface IBoxStorageRepository
    {
        IEnumerable<BoxStorage> GetAll();
        BoxStorage Get(int boxStorageId);
        void Add(BoxStorage boxStorage);
        void Delete(int boxStorageId);
        void Update(BoxStorage boxStorage);
        void Save();
    }
}
