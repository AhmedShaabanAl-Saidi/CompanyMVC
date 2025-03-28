using AutoMapper;
using Company.data.Models;
using Company.service.Interfaces.Department.Dto;

namespace Company.service.Mapping
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department,DepartmentDto>().ReverseMap();
        }
    }
}
