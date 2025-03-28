using Company.data.Contexts;
using Company.data.Models;
using Company.repository.Interfaces;

namespace Company.repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CompanyDbContext _companyDbContext;

        public GenericRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public void Add(T entity)
           => _companyDbContext.Add(entity);

        public void Delete(T entity)
          =>  _companyDbContext.Remove(entity);

        public IEnumerable<T> GetAll()
         => _companyDbContext.Set<T>().ToList();

        public T GetById(int id)
        => _companyDbContext.Set<T>().Find(id);

        public void Update(T entity)
           => _companyDbContext.Update(entity);
    }
}
