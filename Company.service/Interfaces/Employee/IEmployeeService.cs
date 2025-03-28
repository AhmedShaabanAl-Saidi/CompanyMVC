using Company.data.Models;
using Company.service.Interfaces.Employee.Dto;

namespace Company.service.Interfaces
{
    public interface IEmployeeService
    {
        void Add(EmployeeDto employee);
        void Update(EmployeeDto employee);
        void Delete(EmployeeDto employee);
        IEnumerable<EmployeeDto> GetAll();
        EmployeeDto GetById(int? id);
        IEnumerable<EmployeeDto> GetEmployeeByName(string name);
    }
}
