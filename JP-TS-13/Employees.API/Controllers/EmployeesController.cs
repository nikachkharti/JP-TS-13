using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        private List<Employee> _employees = new()
        {
            new Employee
            {
                Id = 1,
                FirstName = "Nika",
                LastName = "Chkhartishvili"
            },
            new Employee
            {
                Id = 2,
                FirstName = "Giorgi",
                LastName = "Giorgadze"
            },
            new Employee
            {
                Id = 3,
                FirstName = "Davit",
                LastName = "Davitidze"
            },
        };

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            var result = _employees.Find(x => x.Id == id);
            return result;
        }


        [HttpGet("{lName}/{id}")]
        public Employee GetEmployeeWithDze(string lName, int id)
        {
            var result = _employees
                .Where(x => x.LastName.EndsWith(lName))
                .FirstOrDefault(x => x.Id == id);

            return result;
        }

        [HttpPost]
        public List<Employee> AddNewEmployee(Employee employee)
        {
            _employees.Add(employee);
            return _employees;
        }

        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
            var employee = _employees.Find(x => x.Id == id);
            _employees.Remove(employee);
        }

        [HttpPut]
        public void UpdateEmployee(int id, Employee newEmployee)
        {
            var employeeToUpdate = _employees.Find(x => x.Id == id);

            employeeToUpdate.FirstName = newEmployee.FirstName;
            employeeToUpdate.LastName = newEmployee.LastName;
        }
    }
}
