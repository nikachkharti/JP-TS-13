using AutoMapper;
using Employees.API.Data;
using Employees.API.Models;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Employees.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private APIResponse _response;
        public UsersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _response = new();
        }

        [HttpPost("login")]
        public async Task<ActionResult<APIResponse>> Login(LoginUserDTO model)
        {
            //დაწერეთ მომხმარებლის user - ავტორიზაციის ლოგიკა.
            throw new NotImplementedException();
        }

        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> Register(RegisterUserDTO model)
        {
            try
            {
                if (model is null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Incorrect data passed." };
                    _response.Result = null;

                    return _response;
                }

                if (await _context.Users.AnyAsync(x => x.Email == model.Email))
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "User already exists." };
                    _response.Result = null;

                    return _response;
                }

                User newUser = _mapper.Map<User>(model);
                newUser.Role = "customer";

                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();

                _response.StatusCode = HttpStatusCode.Created;
                _response.IsSuccess = true;
                _response.Result = newUser;
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
