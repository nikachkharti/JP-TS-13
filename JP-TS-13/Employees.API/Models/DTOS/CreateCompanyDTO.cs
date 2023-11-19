namespace Employees.API.Models.DTOS
{
    public class CreateCompanyDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
