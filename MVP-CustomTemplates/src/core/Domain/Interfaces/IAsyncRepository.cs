using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity<T>
    {
        Task<IReadOnlyList<T>> GetAllAsync();       
        
        Task<T?> GetByIdAsync(T id);
    }
}
