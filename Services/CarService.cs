using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;

    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public Task<Car> AddAsync(Car entity)
    {
        return _carRepository.AddAsync(entity);
    }

    public Task DeleteAsync(Guid uuid)
    {
        return _carRepository.DeleteAsync(uuid);
    }

    public Task<IReadOnlyCollection<Car>> GetAllAsync()
    {
        return _carRepository.GetAllAsync();
    }

    public Task<Car> GetByIdAsync(Guid uuid)
    {
        return _carRepository.GetByIdAsync(uuid);
    }

    public Task<Car> UpdateAsync(Car entity)
    {
        return _carRepository.UpdateAsync(entity);
    }
}
