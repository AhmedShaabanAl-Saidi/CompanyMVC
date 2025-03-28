namespace Company.repository.Interfaces
{
    public interface IUnitOfWork
    {
        public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmpolyeeRepository EmployeeRepository { get; set; }
        int Complete(); 
    }
}