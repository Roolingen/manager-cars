using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dal;

public static class ServiceRegistration
{
    public static void AddDal(this IServiceCollection services)
    {
        services.AddDbContext<CarManagerContext>(opt => opt.UseSqlite());
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
