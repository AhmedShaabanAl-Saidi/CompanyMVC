using Company.data.Models;

namespace Company.repository.Interfaces
{
    public interface IEmpolyeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeeByName(string name);
        IEnumerable<Employee> GetEmployeesByAddress(string address);
    }
}
