using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Dal;

public class CarManagerContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public CarManagerContext(DbContextOptions<CarManagerContext> options) : base(options) { }
}
