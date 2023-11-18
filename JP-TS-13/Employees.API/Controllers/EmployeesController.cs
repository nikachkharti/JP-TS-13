using Employees.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            var result = EmployeesStore.EmployeeList;
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var result = EmployeesStore.EmployeeList.Find(x => x.Id == id);

            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult AddNewEmployee(Employee employee)
        {
            if (employee is null)
            {
                return BadRequest(employee);
            }

            var newId = EmployeesStore.EmployeeList.Max(x => x.Id) + 1;
            employee.Id = newId;

            EmployeesStore.EmployeeList.Add(employee);

            return Created(string.Empty, employee);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var result = EmployeesStore.EmployeeList.Find(x => x.Id == id);

            if (result == null)
            {
                return NotFound(result);
            }

            EmployeesStore.EmployeeList.Remove(result);
            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateEmployee(int id, Employee model)
        {
            if (id <= 0 || model.Id != id)
            {
                return BadRequest();
            }

            var result = EmployeesStore.EmployeeList.Find(x => x.Id == id);

            if (result == null)
            {
                return NotFound(result);
            }

            result.FirstName = model.FirstName;
            result.LastName = model.LastName;

            return Ok(result);
        }


        //private int MaxId(List<Employee> collection)
        //{
        //    int maxElement = collection[0].Id;

        //    foreach (var item in collection)
        //    {
        //        if (item.Id > maxElement)
        //        {
        //            maxElement = item.Id;
        //        }
        //    }

        //    return maxElement;
        //}
    }
}
