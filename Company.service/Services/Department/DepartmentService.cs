using Company.data.Models;
using Company.repository.Interfaces;
using Company.service.Interfaces;

namespace Company.service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Add(Department department)
        {
            var mapperDepartment = new Department
            {
                Name = department.Name,
                Code = department.Code,
                CreatedAt = DateTime.Now,
            };
            _departmentRepository.Add(mapperDepartment);
        }

        public void Delete(Department department)
        {
            _departmentRepository.Delete(department);
        }

        public IEnumerable<Department> GetAll()
        {
            var departments = _departmentRepository.GetAll();

            return departments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
                return null;

            var department = _departmentRepository.GetById(id.Value);

            if (department is null)
                return null;

            return department;
        }

        public void Update(Department department)
        {
            var dept = GetById(department.Id);

            if (dept.Name != department.Name)
            {
                if(GetAll().Any(x => x.Name == department.Name))
                    throw new Exception("Department name already exists");
            }

            dept.Name = department.Name;
            dept.Code = department.Code;

            _departmentRepository.Update(dept);
        }
    }
}
