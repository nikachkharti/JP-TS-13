using Employees.API.Data;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<List<EmployeeDTO>>> GetEmployees()
        {

            List<Employee> employees = await _context.Employees.ToListAsync();

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
        public async Task<ActionResult<EmployeeDTO>> GetEmployee(int id)
        {
            if (id <= 0)
                return BadRequest();

            Employee employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> AddNewEmployee(CreatEmployeeDTO createEmployeeDTO)
        {
            if (createEmployeeDTO is null)
                return BadRequest(createEmployeeDTO);

            if (!await _context.Companies.AnyAsync(x => x.Id == createEmployeeDTO.CompanyId))
                return NotFound("Company don't exists");

            Employee newEmployee = new()
            {
                FirstName = createEmployeeDTO.FirstName,
                LastName = createEmployeeDTO.LastName,
                CompanyId = createEmployeeDTO.CompanyId
            };

            await _context.Employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();

            return Created(string.Empty, newEmployee);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            if (id <= 0)
                return BadRequest();

            Employee result = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            _context.Employees.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateEmployee(int id, UpdateEmployeeDTO updateEmployeeDTO)
        {
            if (id <= 0 || updateEmployeeDTO.Id != id)
                return BadRequest();

            Employee result = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            if (!await _context.Companies.AnyAsync(x => x.Id == updateEmployeeDTO.CompanyId))
                return NotFound("Company don't exists");

            //TODO--Implement automapper logic here...
            result.FirstName = updateEmployeeDTO.FirstName;
            result.LastName = updateEmployeeDTO.LastName;
            result.CompanyId = updateEmployeeDTO.CompanyId;

            _context.Employees.Update(result);
            await _context.SaveChangesAsync();

            return Ok(result);
        }
    }
}
