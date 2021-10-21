using Dal;
using Domain.Models;

namespace Api.Services;

public class CarService
{
    private readonly IRepository<Car> _repository;
    public CarService(IRepository<Car> repository) => _repository;
}
