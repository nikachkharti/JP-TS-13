using System.ComponentModel.DataAnnotations;

namespace Employees.API.Models.DTOS
{
    public class RegisterUserDTO
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
