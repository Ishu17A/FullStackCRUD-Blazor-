using Microsoft.EntityFrameworkCore;
using Web_API_.DBContext;

namespace Web_API_.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDBContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public GenericRepository(AppDBContext context)
        {
            this._context = context;
            entities = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }
        public async Task<T> Get(Guid id)
        {
            return await entities.FindAsync(id);
        }
        public async Task Insert(T entity)
        {
            

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await entities.AddAsync(entity);
            _context.SaveChanges();
        }
        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            var res = await _context.SaveChangesAsync();
        }
        public async Task<bool> Delete(Guid id)
        {
            var entity = await entities.FindAsync(id);
            if (entity != null)
            {
                entities.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }



    }
}
