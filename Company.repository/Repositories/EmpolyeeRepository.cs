using Company.data.Contexts;
using Company.data.Models;
using Company.repository.Interfaces;

namespace Company.repository.Repositories
{
    public class EmpolyeeRepository : GenericRepository<Employee> , IEmpolyeeRepository
    {
        private readonly CompanyDbContext _companyDbContext;
        public EmpolyeeRepository(CompanyDbContext companyDbContext) : base(companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public Employee GetEmployeeByName(string name)
        => _companyDbContext.Employees.Find(name);

        public IEnumerable<Employee> GetEmployeesByAddress(string address)
        => _companyDbContext.Employees.Where(e => e.Address == address).ToList();
    }
}
