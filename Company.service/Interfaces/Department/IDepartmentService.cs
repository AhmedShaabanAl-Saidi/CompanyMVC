using Company.data.Models;
using Company.service.Interfaces.Department.Dto;

namespace Company.service.Interfaces
{
    public interface IDepartmentService
    {
        void Add(DepartmentDto department);
        void Update(DepartmentDto department);
        void Delete(DepartmentDto department);
        IEnumerable<DepartmentDto> GetAll();
        DepartmentDto GetById(int? id);
    }
}
