using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SQL.Adapter.Repositories
{
    public class EfCoreRepository<T> : IAsyncRepository<T> where T : BaseEntity<T>
    {
        protected readonly DatabaseContext _dbContext;

        public EfCoreRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(T id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
