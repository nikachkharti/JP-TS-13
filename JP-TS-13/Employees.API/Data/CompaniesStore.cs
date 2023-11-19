namespace Employees.API.Data
{
    public static class CompaniesStore
    {
        public static List<Company> CompanyList { get; set; } = new()
        {
            new Company { Id = 1, Name = "Apple", Description = "Apple company test description", CreateDate = DateTime.Now },
            new Company { Id = 2, Name = "Microsoft", Description = "Microsoft company test description", CreateDate = DateTime.Now },
            new Company { Id = 3, Name = "Intel", Description = "Intel company test description", CreateDate = DateTime.Now }
        };
    }
}
