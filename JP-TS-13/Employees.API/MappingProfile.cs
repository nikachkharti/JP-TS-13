using AutoMapper;
using Employees.API.Models;
using Employees.API.Models.DTOS;

namespace Employees.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>();
            CreateMap<CreateCompanyDTO, Company>();
            CreateMap<UpdateCompanyDTO, Company>();

            CreateMap<Employee, EmployeeDTO>();
            CreateMap<CreatEmployeeDTO, Employee>();
            CreateMap<UpdateEmployeeDTO, Employee>();

            CreateMap<RegisterUserDTO, User>();
            CreateMap<LoginUserDTO, User>();
        }
    }
}
