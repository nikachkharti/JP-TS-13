using Employees.API.Data;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<EmployeeDTO>> GetEmployees()
        {
            List<Employee> employees = EmployeesStore.EmployeeList;

            if (employees.Count == 0)
            {
                return NoContent();
            }

            List<EmployeeDTO> result = employees.Select(x => new EmployeeDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
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

            Employee employee = EmployeesStore.EmployeeList.Find(x => x.Id == id);

            if (employee == null)
                return NotFound(employee);

            EmployeeDTO result = new()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
            };

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddNewEmployee(CreatEmployeeDTO createEmployeeDTO)
        {
            if (createEmployeeDTO is null)
            {
                return BadRequest(createEmployeeDTO);
            }

            var newId = EmployeesStore.EmployeeList.Max(x => x.Id) + 1;

            Employee newEmployee = new()
            {
                Id = newId,
                FirstName = createEmployeeDTO.FirstName,
                LastName = createEmployeeDTO.LastName,
            };

            EmployeesStore.EmployeeList.Add(newEmployee);

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

            Employee result = EmployeesStore.EmployeeList.Find(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            EmployeesStore.EmployeeList.Remove(result);
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

            Employee result = EmployeesStore.EmployeeList.Find(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            result.FirstName = updateEmployeeDTO.FirstName;
            result.LastName = updateEmployeeDTO.LastName;

            return Ok(result);
        }
    }
}
