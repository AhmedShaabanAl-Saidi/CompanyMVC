using Company.data.Models;

namespace Company.repository.Interfaces
{
    public interface IEmpolyeeRepository : IGenericRepository<Employee>
    {
        Employee GetEmployeeByName(string name);
        IEnumerable<Employee> GetEmployeesByAddress(string address);
    }
}
