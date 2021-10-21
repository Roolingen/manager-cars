using System;
using System.Collections.Generic;
using Domain.Models;

namespace Dal;

public interface ICarRepository : IDisposable
{
    IEnumerable<Car> GetCar();
    Car GetCarById(long carId);
    void InsertCar(Car car);
    void DeleteCar(int carId);
    void UpdateCar(Car car);
    void Save();
}
