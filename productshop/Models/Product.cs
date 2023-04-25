using System.ComponentModel.DataAnnotations;

namespace productshop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImgURL { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public double ProductPrice { get; set; }

        // Relationship
        public List<ProductCategory> ProductCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
