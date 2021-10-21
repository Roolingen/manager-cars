using System;
using System.Collections.Generic;
using Domain.Models;

namespace Dal;

public class CarRepository : ICarRepository, IDisposable
{
    // private CarManagerContext context;
    public void DeleteCar(int carId)
    {
        throw new System.NotImplementedException();
    }

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public IEnumerable<Car> GetCar()
    {
        throw new System.NotImplementedException();
    }

    public Car GetCarById(long carId)
    {
        throw new System.NotImplementedException();
    }

    public void InsertCar(Car car)
    {
        throw new System.NotImplementedException();
    }

    public void Save()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateCar(Car car)
    {
        throw new System.NotImplementedException();
    }
}
