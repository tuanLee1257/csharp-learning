using Microsoft.EntityFrameworkCore;
using productshop.Models;

namespace productshop.Data.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

        }

        public void Delete(int productid)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            if (data != null)
            {
                _context.Products.Remove(data);
                _context.SaveChanges();

            }
        }

        public List<Product> GetProducts()
        {

            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
