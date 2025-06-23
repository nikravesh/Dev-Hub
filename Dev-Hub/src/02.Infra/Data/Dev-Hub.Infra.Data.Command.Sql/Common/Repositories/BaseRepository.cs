using System.Linq.Expressions;

using Dev_Hub.Core.Contract.Common.Repositories;
using Dev_Hub.Infra.Data.Command.Sql.Data;

using Microsoft.EntityFrameworkCore;

namespace Dev_Hub.Infra.Data.Command.Sql.Common.Repositories;
public abstract class BaseRepository<TDbContext, TEntity, TId> : IBaseRepository<TEntity, TId>
    where TDbContext : Dev_HubDbContext
    where TEntity : class
    where TId : struct
{

    protected readonly TDbContext _dbContext;

    public BaseRepository(TDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Delete(TId id)
    {
        TEntity? entity = _dbContext.Set<TEntity>().Find(id);
        if (entity is null) return;

        _dbContext.Set<TEntity>().Remove(entity);

        SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        SaveChanges();
    }

    public async Task DeleteAsync(TId id)
    {
        TEntity? entity = await _dbContext.Set<TEntity>().FindAsync(id);
        if (entity is null) return;

        _dbContext.Set<TEntity>().Remove(entity);

        await SaveChangesAsync();
    }

    public bool Exists(Expression<Func<TEntity, bool>> expression) => _dbContext.Set<TEntity>().Any(expression);

    public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression) => await _dbContext.Set<TEntity>().AnyAsync(expression);
    
    public TEntity? GetById(TId id) => _dbContext.Set<TEntity>().Find(id);

    public async Task<TEntity?> GetByIdAsync(TId id) => await _dbContext.Set<TEntity>().FindAsync(id);

    public void Insert(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        SaveChanges();
    }

    public async Task InsertAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> SelectAllAsync() => await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();

    public void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        SaveChanges();
    }

    private async Task SaveChangesAsync() => await _dbContext.SaveChangesAsync();

    private void SaveChanges() => _dbContext.SaveChanges();
}
