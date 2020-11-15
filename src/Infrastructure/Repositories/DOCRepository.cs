using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class DOCRepository : IDOCRepository, IRepository<DOC>
    {
        private readonly ApplicationContext _context;
        public DOCRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<DOC> GetAll()
        {
            return _context.DOCs;
        }
        public DOC Get(int docId)
        {
            return _context.DOCs.SingleOrDefault(c => c.Id == docId);
        }

        public void Add(DOC doc)
        {
            _context.DOCs.Add(doc);
        }

        public void Delete(int docId)
        {
            _context.DOCs.Remove(Get(docId));
        }

        public void Update(DOC doc)
        {
            _context.DOCs.Update(doc);
        }
    }
}
