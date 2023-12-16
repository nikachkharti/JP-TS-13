using System.ComponentModel.DataAnnotations;

namespace Employees.API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [MaxLength(30)]
        public string Role { get; set; }
    }
}
