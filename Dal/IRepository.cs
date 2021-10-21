namespace Dal;

public interface IRepository<TEntity> where TEntity : struct
{
    IQueryable<TEntity> GetAll();
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}
