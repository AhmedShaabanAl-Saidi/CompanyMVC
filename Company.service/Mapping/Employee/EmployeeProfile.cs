using AutoMapper;
using Company.data.Models;
using Company.service.Interfaces.Employee.Dto;

namespace Company.service.Mapping
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
