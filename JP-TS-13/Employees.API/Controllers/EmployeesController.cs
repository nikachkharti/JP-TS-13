using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        private List<Employee> employees = new();
        public EmployeesController()
        {
            employees.Add(
                    new Employee()
                    {
                        Id = 1,
                        FirstName = "Nika",
                        LastName = "Chkhartishvili"
                    }
                );

            employees.Add(
                 new Employee()
                 {
                     Id = 2,
                     FirstName = "Giorgi",
                     LastName = "Giorgadze"
                 }
            );

            employees.Add(
                new Employee()
                {
                    Id = 3,
                    FirstName = "Davit",
                    LastName = "Davitidze"
                }
            );

        }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            var result = employees.Find(x => x.Id == id);
            return result;
        }


        [HttpGet("{lName}/{id}")]
        public Employee GetEmployeeWithDze(string lName, int id)
        {
            var result = employees
                .Where(x => x.LastName.EndsWith(lName))
                .FirstOrDefault(x => x.Id == id);

            return result;
        }

        [HttpPost]
        public void AddNewEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
