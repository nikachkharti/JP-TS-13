using System.ComponentModel.DataAnnotations;

namespace Employees.API.Models.DTOS
{
    public class CreatEmployeeDTO
    {
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(30)]
        [Required]
        public string LastName { get; set; }
    }
}
