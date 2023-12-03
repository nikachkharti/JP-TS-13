using Employees.API.Data;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Employees.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public EmployeesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<EmployeeDTO>>> GetEmployees()
        {

            List<Employee> employees = await _context.Employees
                .Include("Company")
                .ToListAsync();

            if (employees.Count == 0)
                return NoContent();

            List<EmployeeDTO> result = _mapper.Map<List<EmployeeDTO>>(employees);

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

            Employee employee = await _context.Employees
                .Include("Company")
                .FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
                return NotFound(employee);

            EmployeeDTO result = _mapper.Map<EmployeeDTO>(employee);

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


            Employee newEmployee = _mapper.Map<Employee>(createEmployeeDTO);

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
        public async Task<ActionResult> UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            if (!await _context.Employees.AnyAsync(x => x.Id == updateEmployeeDTO.Id))
                return NotFound("Employee don't exsits");

            if (updateEmployeeDTO.Id <= 0 || updateEmployeeDTO == null)
                return BadRequest();

            Employee result = _mapper.Map<Employee>(updateEmployeeDTO);

            if (result == null)
                return NotFound(result);

            if (!await _context.Companies.AnyAsync(x => x.Id == updateEmployeeDTO.CompanyId))
                return NotFound("Company don't exists");

            _context.Employees.Update(result);
            await _context.SaveChangesAsync();

            return Ok(result);
        }
    }
}
