using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        
        TDocument FindOne(Expression<Func<TDocument, bool>> filterExpression);

        Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression);

        TDocument FindById(string id);

        Task<TDocument> FindByIdAsync(string id);

    }
}
