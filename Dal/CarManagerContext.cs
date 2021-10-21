using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Dal;

public class CarManagerContext : DbContext
{
    public CarManagerContext(DbContextOptions<CarManagerContext> options) : base(options) { }

    public virtual DbSet<Car> Cars => Set<Car>();
    public virtual DbSet<Make> Makes => Set<Make>();
    public virtual DbSet<Model> Models => Set<Model>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.Make)
                .IsRequired();

            entity.Property(e => e.Model)
                .IsRequired();
        });

        modelBuilder.Entity<Make>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired();
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired();
        });

        base.OnModelCreating(modelBuilder);
    }
}
