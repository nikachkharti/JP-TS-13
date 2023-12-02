using AutoMapper;
using Employees.API.Data;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees.API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CompaniesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CompanyDTO>>> GetCompanies()
        {
            List<Company> companies = await _context.Companies.ToListAsync();

            if (companies.Count == 0)
                return NoContent();

            List<CompanyDTO> result = _mapper.Map<List<CompanyDTO>>(companies);
            return Ok(result);

            //ძველი კოდი ხელით mapping
            //List<CompanyDTO> result = companies.Select(x => new CompanyDTO
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    CreateDate = x.CreateDate,
            //    Description = x.Description
            //}).ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CompanyDTO>> GetCompany(int id)
        {
            if (id <= 0)
                return BadRequest();

            Company company = await _context.Companies.FirstOrDefaultAsync(x => x.Id == id);

            if (company == null)
                return NotFound(company);

            CompanyDTO result = _mapper.Map<CompanyDTO>(company);
            return Ok(result);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> AddNewCompany(CreateCompanyDTO createCompanyDTO)
        {
            if (createCompanyDTO is null)
                return BadRequest(createCompanyDTO);

            Company newCompany = _mapper.Map<Company>(createCompanyDTO);

            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();

            return Created(string.Empty, newCompany);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteCompany(int id)
        {
            if (id <= 0)
                return BadRequest();

            Company result = await _context.Companies.FirstOrDefaultAsync(x => x.Id == id);

            if (result == null)
                return NotFound(result);

            _context.Companies.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateCompany(int id, UpdateCompanyDTO updateCompanyDTO)
        {
            if (id <= 0 || updateCompanyDTO.Id != id)
                return BadRequest();

            Company result = _mapper.Map<Company>(updateCompanyDTO);

            if (result == null)
                return NotFound(result);

            _context.Companies.Update(result);
            await _context.SaveChangesAsync();

            return Ok(result);
        }
    }
}
