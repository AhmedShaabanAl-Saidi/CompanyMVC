using Company.data.Contexts;
using Company.data.Models;
using Company.repository.Interfaces;

namespace Company.repository.Repositories
{
    public class DepartmentRepository : GenericRepository<Department> , IDepartmentRepository
    {
        public DepartmentRepository(CompanyDbContext companyDbContext) : base(companyDbContext)
        {
        }
    }
}
