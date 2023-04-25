using productshop.Models;

namespace productshop.Data.Service
{
    public interface IProductService
    {
        List<Product> GetProducts();
        void Add(Product product);
        void Update(Product product);
        void Delete(int productid);
    }
}
