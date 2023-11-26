﻿using Employees.API.Data;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<CompanyDTO>> GetCompanies()
        {
            List<Company> companies = _context.Companies.ToList();

            if (companies.Count == 0)
                return NoContent();

            //TODO--Implement automapper logic here...
            List<CompanyDTO> result = companies.Select(x => new CompanyDTO
            {
                Id = x.Id,
                Name = x.Name,
                CreateDate = x.CreateDate,
                Description = x.Description
            }).ToList();

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CompanyDTO> GetCompany(int id)
        {
            if (id <= 0)
                return BadRequest();

            Company company = _context.Companies.FirstOrDefault(x => x.Id == id);

            if (company == null)
                return NotFound(company);

            //TODO--Implement automapper logic here...
            CompanyDTO result = new()
            {
                Id = company.Id,
                Name = company.Name,
                CreateDate = company.CreateDate,
                Description = company.Description
            };

            return Ok(result);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddNewCompany(CreateCompanyDTO createCompanyDTO)
        {
            if (createCompanyDTO is null)
                return BadRequest(createCompanyDTO);

            //TODO--Implement automapper logic here...
            Company newCompany = new()
            {
                Name = createCompanyDTO.Name,
                Description = createCompanyDTO.Description,
                CreateDate = createCompanyDTO.CreateDate
            };

            _context.Companies.Add(newCompany);
            _context.SaveChanges();

            return Created(string.Empty, newCompany);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteCompany(int id)
        {
            if (id <= 0)
                return BadRequest();

            Company result = _context.Companies.FirstOrDefault(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            _context.Companies.Remove(result);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult UpdateCompany(int id, UpdateCompanyDTO updateCompanyDTO)
        {
            if (id <= 0 || updateCompanyDTO.Id != id)
                return BadRequest();

            Company result = _context.Companies.FirstOrDefault(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            //TODO--Implement automapper logic here...
            result.Name = updateCompanyDTO.Name;
            result.Description = updateCompanyDTO.Description;
            result.CreateDate = updateCompanyDTO.CreateDate;

            _context.Companies.Update(result);
            _context.SaveChanges();

            return Ok(result);
        }
    }
}
