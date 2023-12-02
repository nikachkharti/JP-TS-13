using AutoMapper;
using Employees.API.Models.DTOS;

namespace Employees.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>();
        }
    }
}
