using System.ComponentModel.DataAnnotations;

namespace Employees.API.Models.DTOS
{
    public class LoginUserDTO
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
