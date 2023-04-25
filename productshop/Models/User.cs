using System.ComponentModel.DataAnnotations;

namespace productshop.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required] 
        public string Password { get; set; }

        // Relationship
        public List<Order> Orders { get; set; }
        public List<UserRole> UserRoles { get; set; }


    }
}
