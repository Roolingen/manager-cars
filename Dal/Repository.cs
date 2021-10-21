namespace Dal;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : struct
{
    protected readonly CarManagerContext CarManagerContext;

    public Repository(CarManagerContext carManagerContext)
    {
        CarManagerContext = carManagerContext;
    }

    public IQueryable<TEntity> GetAll()
    {
        try
        {
            return CarManagerContext.Set<TEntity>();
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve entities: {ex.Message}");
        }
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
        }

        try
        {
            await CarManagerContext.AddAsync(entity);
            await CarManagerContext.SaveChangesAsync();

            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
        }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
        }

        try
        {
            CarManagerContext.Update(entity);
            await CarManagerContext.SaveChangesAsync();

            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
        }
    }
}
