using Company.data.Models;

namespace Company.service.Interfaces
{
    public interface IDepartmentService
    {
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
        IEnumerable<Department> GetAll();
        Department GetById(int? id);
    }
}
