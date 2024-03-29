﻿using System.ComponentModel.DataAnnotations;

namespace Employees.API.Models.DTOS
{
    public class UpdateEmployeeDTO
    {
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(30)]
        [Required]
        public string LastName { get; set; }
        public int CompanyId { get; set; }
    }
}
