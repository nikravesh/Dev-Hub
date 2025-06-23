using System.Linq.Expressions;

namespace Dev_Hub.Core.Contract.Common.Repositories;
public interface IBaseRepository<TEntity, TId>
{
    void Delete(TId id);
    void Delete(TEntity entity);
    Task DeleteAsync(TId id);
    TEntity? GetById(TId id);
    Task<TEntity?> GetByIdAsync(TId id);
    void Insert(TEntity entity);
    Task InsertAsync(TEntity entity);
    Task<IEnumerable<TEntity>> SelectAllAsync();
    void Update(TEntity entity);
    bool Exists(Expression<Func<TEntity, bool>> expression);
    Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression);
}
