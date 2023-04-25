using System.ComponentModel.DataAnnotations;

namespace productshop.Models
{
    public class Category
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        // Relationship
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
