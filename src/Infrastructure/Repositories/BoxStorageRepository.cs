using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class BoxStorageRepository : IBoxStorageRepository, IRepository<BoxStorage>
    {
        private readonly ApplicationContext _context;
        public BoxStorageRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<BoxStorage> GetAll()
        {
            return _context.BoxStorage;
        }
        public BoxStorage Get(int boxStorageId)
        {
            return _context.BoxStorage.SingleOrDefault(bs => bs.Id == boxStorageId);
        }

        public void Add(BoxStorage boxStorage)
        {
            _context.BoxStorage.Add(boxStorage);
        }

        public void Delete(int boxStorageId)
        {
            _context.BoxStorage.Remove(Get(boxStorageId));
        }

        public void Update(BoxStorage boxStorage)
        {
            _context.BoxStorage.Update(boxStorage);
        }
    }
}
