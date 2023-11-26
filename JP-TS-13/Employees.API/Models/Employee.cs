using System.ComponentModel.DataAnnotations;

namespace Employees.API
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(30)]
        [Required]
        public string LastName { get; set; }
    }


}
