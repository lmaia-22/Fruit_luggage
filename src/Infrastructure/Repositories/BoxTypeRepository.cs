using Domain;
using Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class BoxTypeRepository : IBoxTypeRepository, IRepository<BoxType> {
        private readonly ApplicationContext _context;
        public BoxTypeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<BoxType> GetAll()
        {
            return _context.BoxTypes;
        }
        public BoxType Get(int boxTypeId)
        {
            return _context.BoxTypes.SingleOrDefault(bs => bs.Id == boxTypeId);
        }

        public void Add(BoxType boxType)
        {
            _context.BoxTypes.Add(boxType);
        }

        public void Delete(int boxTypeId)
        {
            _context.BoxTypes.Remove(Get(boxTypeId));
        }

        public void Update(BoxType boxType)
        {
            _context.BoxTypes.Update(boxType);
        }
    }
}
