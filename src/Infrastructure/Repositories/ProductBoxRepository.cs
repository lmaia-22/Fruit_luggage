using Domain;
using Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class ProductBoxRepository : IProductBoxRepository, IRepository<ProductBox>
    {
        private readonly ApplicationContext _context;
        public ProductBoxRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductBox> GetAll()
        {
            return _context.ProductBoxes;
        }
        public ProductBox Get(int productBoxId)
        {
            return _context.ProductBoxes.SingleOrDefault(c => c.Id == productBoxId);
        }

        public void Add(ProductBox productBox)
        {
            _context.ProductBoxes.Add(productBox);
        }

        public void Delete(int productBoxId)
        {
            _context.ProductBoxes.Remove(Get(productBoxId));
        }

        public void Update(ProductBox productBox)
        {
            _context.ProductBoxes.Update(productBox);
        }
    }
}
