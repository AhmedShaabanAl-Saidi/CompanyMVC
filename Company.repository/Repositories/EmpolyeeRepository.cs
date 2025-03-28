using Company.data.Contexts;
using Company.data.Models;
using Company.repository.Interfaces;

namespace Company.repository.Repositories
{
    public class EmpolyeeRepository : GenericRepository<Employee>, IEmpolyeeRepository
    {
        private readonly CompanyDbContext _companyDbContext;
        public EmpolyeeRepository(CompanyDbContext companyDbContext) : base(companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public IEnumerable<Employee> GetEmployeeByName(string name)
        => _companyDbContext.Employees.Where(x =>
        x.Name.Trim().ToLower().Contains(name.Trim().ToLower()) ||
        x.Email.Trim().ToLower().Contains(name.Trim().ToLower()) ||
        x.PhoneNumber.Trim().ToLower().Contains(name.Trim().ToLower())).ToList();

        public IEnumerable<Employee> GetEmployeesByAddress(string address)
        => _companyDbContext.Employees.Where(x => x.Address.Trim().ToLower().Contains(address.Trim().ToLower())).ToList();
    }
}
