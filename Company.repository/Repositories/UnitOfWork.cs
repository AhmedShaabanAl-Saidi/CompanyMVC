using Company.data.Contexts;
using Company.repository.Interfaces;

namespace Company.repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CompanyDbContext _context;

        public UnitOfWork(CompanyDbContext context)
        {
            _context = context;
            DepartmentRepository = new DepartmentRepository(context);
            EmployeeRepository = new EmpolyeeRepository(context);
        }
        public IDepartmentRepository DepartmentRepository { get ; set ; }
        public IEmpolyeeRepository EmployeeRepository { get ; set ; }

        public int Complete()
            => _context.SaveChanges();
    }
}
