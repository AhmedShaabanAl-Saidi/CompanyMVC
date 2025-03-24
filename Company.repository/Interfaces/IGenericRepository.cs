using Company.data.Models;

namespace Company.repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
