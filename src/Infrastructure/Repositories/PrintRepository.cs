using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class PrintRepository : IPrintRepository, IRepository<Print>
    {
        private readonly ApplicationContext _context;
        public PrintRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Print> GetAll()
        {
            return _context.Prints;
        }
        public Print Get(int printId)
        {
            return _context.Prints.SingleOrDefault(c => c.Id == printId);
        }

        public void Add(Print print)
        {
            _context.Prints.Add(print);
        }

        public void Delete(int printId)
        {
            _context.Prints.Remove(Get(printId));
        }

        public void Update(Print print)
        {
            _context.Prints.Update(print);
        }
    }
}
