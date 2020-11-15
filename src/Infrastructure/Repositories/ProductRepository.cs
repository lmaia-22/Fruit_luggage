using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository, IRepository<Product>
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
        public Product Get(int productId)
        {
            return _context.Products.SingleOrDefault(c => c.Id == productId);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(Get(productId));
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
