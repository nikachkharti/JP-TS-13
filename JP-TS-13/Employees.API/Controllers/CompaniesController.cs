using Employees.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Company>> GetCompanies()
        {
            var result = CompaniesStore.CompanyList;
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetCompany(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var result = CompaniesStore.CompanyList.Find(x => x.Id == id);

            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult AddNewCompany(Company company)
        {
            if (company is null)
            {
                return BadRequest(company);
            }

            var newId = CompaniesStore.CompanyList.Max(x => x.Id) + 1;
            company.Id = newId;

            CompaniesStore.CompanyList.Add(company);

            return Created(string.Empty, company);
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteCompany(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var result = CompaniesStore.CompanyList.Find(x => x.Id == id);

            if (result == null)
            {
                return NotFound(result);
            }

            CompaniesStore.CompanyList.Remove(result);
            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateCompany(int id, Company model)
        {
            if (id <= 0 || model.Id != id)
            {
                return BadRequest();
            }

            var result = CompaniesStore.CompanyList.Find(x => x.Id == id);

            if (result == null)
            {
                return NotFound(result);
            }

            result.Name = model.Name;
            result.Description = model.Description;
            result.CreateDate = model.CreateDate;

            return Ok(result);
        }


    }
}
