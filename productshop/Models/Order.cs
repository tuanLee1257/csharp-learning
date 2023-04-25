using System.ComponentModel.DataAnnotations;

namespace productshop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } 
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime CompleteDate { get; set; }


        // Relationship
        public User User { get; set; }
        public int UserId { get; set; }

        public List<OrderDetail> OrdersDetails { get; set; }
    }
}
