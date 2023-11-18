namespace Employees.API.Data
{
    public static class EmployeesStore
    {
        public static List<Employee> EmployeeList { get; set; } = new()
        {
            new Employee { Id = 1, FirstName = "Nika", LastName = "Chkhartishvili" },
            new Employee { Id = 2, FirstName = "Giorgi", LastName = "Giorgadze" },
            new Employee { Id = 3, FirstName = "Davit", LastName = "Davitidze" }
        };
    }
}
