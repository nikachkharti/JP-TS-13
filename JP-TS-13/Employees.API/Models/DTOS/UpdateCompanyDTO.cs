namespace Employees.API.Models.DTOS
{
    public class UpdateCompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
