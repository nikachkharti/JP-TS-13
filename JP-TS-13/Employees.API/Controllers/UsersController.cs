using AutoMapper;
using Employees.API.Data;
using Employees.API.Models;
using Employees.API.Models.DTOS;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<ActionResult<APIResponse>> Login([FromBody] LoginUserDTO model)
        {
            //დაწერეთ მომხმარებლის user - ავტორიზაციის ლოგიკა.
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult<APIResponse>> Register([FromBody] RegisterUserDTO model)
        {
            //დაწერეთ მომხმარებლის user - რეგისტრაციის ლოგიკა.
            throw new NotImplementedException();
        }
    }
}
