using Employees.API.Data;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<EmployeeDTO>> GetEmployees()
        {

            List<Employee> employees = _context.Employees.ToList();

            if (employees.Count == 0)
                return NoContent();

            //TODO--Implement automapper logic here...
            List<EmployeeDTO> result = employees.Select(x => new EmployeeDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Company = _context.Companies.FirstOrDefault(y => y.Id == x.CompanyId)
            }).ToList();

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<EmployeeDTO> GetEmployee(int id)
        {
            if (id <= 0)
                return BadRequest();

            Employee employee = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
                return NotFound(employee);

            //TODO--Implement automapper logic here...
            EmployeeDTO result = new()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Company = _context.Companies.FirstOrDefault(x => x.Id == employee.CompanyId)
            };

            return Ok(result);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddNewEmployee(CreatEmployeeDTO createEmployeeDTO)
        {
            if (createEmployeeDTO is null)
                return BadRequest(createEmployeeDTO);

            Employee newEmployee = new()
            {
                FirstName = createEmployeeDTO.FirstName,
                LastName = createEmployeeDTO.LastName,
            };

            _context.Employees.Add(newEmployee);
            _context.SaveChanges();

            return Created(string.Empty, newEmployee);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
                return BadRequest();

            Employee result = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            _context.Employees.Remove(result);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult UpdateEmployee(int id, UpdateEmployeeDTO updateEmployeeDTO)
        {
            if (id <= 0 || updateEmployeeDTO.Id != id)
                return BadRequest();

            Employee result = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            //TODO--Implement automapper logic here...
            result.FirstName = updateEmployeeDTO.FirstName;
            result.LastName = updateEmployeeDTO.LastName;

            _context.Employees.Update(result);
            _context.SaveChanges();

            return Ok(result);
        }
    }
}
