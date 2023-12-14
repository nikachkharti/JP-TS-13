using AutoMapper;
using Employees.API.Data;
using Employees.API.Models;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Employees.API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private APIResponse _response;
        public CompaniesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetCompanies()
        {
            try
            {
                List<Company> companies = await _context.Companies.ToListAsync();

                if (companies.Count == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Companies not found." };
                    _response.Result = null;

                    return _response;
                }

                List<CompanyDTO> result = _mapper.Map<List<CompanyDTO>>(companies);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
                _response.Result = null;
            }

            return _response;

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
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetCompany(int id)
        {
            try
            {
                if (id <= 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Incorrect data passed." };
                    _response.Result = null;

                    return _response;
                }

                Company company = await _context.Companies.FirstOrDefaultAsync(x => x.Id == id);

                if (company == null)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Companies not found." };
                    _response.Result = null;

                    return _response;
                }

                CompanyDTO result = _mapper.Map<CompanyDTO>(company);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
                _response.Result = null;
            }

            return _response;
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> AddNewCompany(CreateCompanyDTO createCompanyDTO)
        {
            try
            {
                if (createCompanyDTO is null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Incorrect data passed." };
                    _response.Result = null;

                    return _response;
                }

                Company newCompany = _mapper.Map<Company>(createCompanyDTO);

                await _context.Companies.AddAsync(newCompany);
                await _context.SaveChangesAsync();

                _response.StatusCode = HttpStatusCode.Created;
                _response.IsSuccess = true;
                _response.Result = newCompany;
            }

            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
                _response.Result = null;
            }

            return _response;
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> DeleteCompany(int id)
        {
            try
            {
                if (id <= 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Incorrect data passed." };
                    _response.Result = null;

                    return _response;
                }

                Company result = await _context.Companies.FirstOrDefaultAsync(x => x.Id == id);

                if (result == null)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Company not found." };
                    _response.Result = null;

                    return _response;
                }

                _context.Companies.Remove(result);
                await _context.SaveChangesAsync();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
                _response.Result = null;
            }

            return _response;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> UpdateCompany(UpdateCompanyDTO updateCompanyDTO)
        {
            try
            {
                if (!await _context.Companies.AnyAsync(x => x.Id == updateCompanyDTO.Id))
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Company not found." };
                    _response.Result = null;

                    return _response;
                }

                if (updateCompanyDTO.Id <= 0 || updateCompanyDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Incorrect data passed." };
                    _response.Result = null;

                    return _response;
                }

                Company result = _mapper.Map<Company>(updateCompanyDTO);

                if (result == null)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Company not found." };
                    _response.Result = null;

                    return _response;
                }

                _context.Companies.Update(result);
                await _context.SaveChangesAsync();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
                _response.Result = null;
            }

            return _response;
        }
    }
}
