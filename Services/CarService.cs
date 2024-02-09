using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car Add(Car entity)
        {
            return _carRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _carRepository.Delete(uuid);
        }

        public IReadOnlyCollection<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public Car GetById(Guid uuid)
        {
            return _carRepository.GetById(uuid);
        }

        public Car Update(Car entity)
        {
            return _carRepository.Update(entity);
        }
    }
}
