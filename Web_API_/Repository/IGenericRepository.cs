using Web_API_.Model;

namespace Web_API_.Repository
{
    public interface IGenericRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task Insert(T entity);
        Task Update(T entity);
        Task<bool> Delete(Guid id);


    }
}
